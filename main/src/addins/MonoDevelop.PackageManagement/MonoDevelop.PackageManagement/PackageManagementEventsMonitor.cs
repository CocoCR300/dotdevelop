//
// PackageManagementEventsMonitor.cs
//
// Author:
//       Matt Ward <matt.ward@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using ICSharpCode.PackageManagement;
using MonoDevelop.Core;
using NuGet;

namespace MonoDevelop.PackageManagement
{
	public class PackageManagementEventsMonitor : IDisposable
	{
		IProgressMonitor progressMonitor;
		IPackageManagementEvents packageManagementEvents;
		ManagePackagesUserPrompts userPrompts;

		public PackageManagementEventsMonitor (
			IProgressMonitor progressMonitor,
			IPackageManagementEvents packageManagementEvents)
		{
			this.progressMonitor = progressMonitor;
			this.packageManagementEvents = packageManagementEvents;
			userPrompts = new ManagePackagesUserPrompts (new ThreadSafePackageManagementEvents (packageManagementEvents));

			packageManagementEvents.PackageOperationMessageLogged += PackageOperationMessageLogged;
		}

		public void Dispose ()
		{
			userPrompts.Dispose ();
			packageManagementEvents.PackageOperationMessageLogged -= PackageOperationMessageLogged;
		}
		
		void PackageOperationMessageLogged (object sender, PackageOperationMessageLoggedEventArgs e)
		{
			if (e.Message.Level == MessageLevel.Warning) {
				ReportWarning (e.Message.ToString ());
			} else {
				LogMessage (e.Message.ToString ());
			}
		}

		void ReportWarning (string message)
		{
			progressMonitor.ReportWarning (message);
			LogMessage (message);

			HasWarnings = true;
		}

		void LogMessage (string message)
		{
			progressMonitor.Log.WriteLine (message);
		}

		public bool HasWarnings { get; private set; }

		public void ReportResult (ProgressMonitorStatusMessage progressMessage)
		{
			if (HasWarnings) {
				progressMonitor.ReportSuccess (progressMessage.Warning);
			} else {
				progressMonitor.ReportSuccess (progressMessage.Success);
			}
		}
	}
}

