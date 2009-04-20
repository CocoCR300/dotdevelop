// 
// MonoRuntimeInfo.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
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
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using MonoDevelop.Core.Execution;
using MonoDevelop.Core.Serialization;

namespace MonoDevelop.Core.Assemblies
{
	public class MonoRuntimeInfo
	{
		[ItemProperty]
		string prefix;
		
		string monoVersion = "Unknown";
		Dictionary<string,string> envVars = new Dictionary<string, string> ();
		bool initialized;
		bool isValidRuntime;
		
		internal MonoRuntimeInfo ()
		{
		}
		
		public MonoRuntimeInfo (string prefix)
		{
			this.prefix = prefix;
			Initialize ();
		}
		
		public string Prefix {
			get { return prefix; }
		}
		
		public string MonoVersion {
			get {
				Initialize ();
				return monoVersion;
			}
		}
		
		public string DisplayName {
			get { return "Mono " + MonoVersion; }
		}
		
		public bool IsValidRuntime {
			get {
				Initialize ();
				return isValidRuntime; 
			}
		}
		
		void Initialize ()
		{
			if (!initialized) {
				initialized = true;
				isValidRuntime = InternalInitialize ();
			}
		}
		
		bool InternalInitialize ()
		{
			string libDir = Path.Combine (prefix, "lib");
			if (!Directory.Exists (Path.Combine (libDir, "mono")))
				return false;
			string binDir = Path.Combine (prefix, "bin");
			envVars ["PATH"] = libDir + Path.PathSeparator + binDir + Path.PathSeparator + "$PATH";
			envVars ["LD_LIBRARY_PATH"] = libDir + Path.PathSeparator + "$LD_LIBRARY_PATH";
			envVars ["MONO_PATH"] = libDir + Path.PathSeparator + binDir;
			envVars ["PKG_CONFIG_PATH"] = Path.Combine (libDir, "pkgconfig");
			StringWriter output = new StringWriter ();
			try {
				string monoPath = Path.Combine (prefix, "bin");
				monoPath = Path.Combine (monoPath, "mono");
				ProcessStartInfo pi = new ProcessStartInfo (monoPath, "--version");
				pi.UseShellExecute = false;
				pi.RedirectStandardOutput = true;
				foreach (KeyValuePair<string,string> var in envVars) {
					pi.EnvironmentVariables [var.Key] = var.Value;
				}
				ProcessWrapper p = Runtime.ProcessService.StartProcess (pi, output, null, null);
				p.WaitForOutput ();
			} catch {
				return false;
			}
			
			string ver = output.ToString ();
			int i = ver.IndexOf ("version");
			if (i == -1)
				return false;
			i += 8;
			int j = ver.IndexOf (' ', i);
			if (j == -1)
				return false;
			
			monoVersion = ver.Substring (i, j - i);
			
			return true;
		}
		
		internal Dictionary<string,string> GetEnvironmentVariables ()
		{
			Initialize ();
			return envVars;
		}
	}
}
