
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Debugger
{
	public partial class DebuggerOptionsPanelWidget
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.CheckButton checkProjectCodeOnly;
		private global::Gtk.CheckButton checkStepOverPropertiesAndOperators;
		private global::Gtk.CheckButton checkAllowEval;
		private global::Gtk.Alignment alignmentAllowToString;
		private global::Gtk.CheckButton checkAllowToString;
		private global::Gtk.CheckButton checkAllowTypeLoad;
		private global::Gtk.CheckButton checkShowBaseGroup;
		private global::Gtk.CheckButton checkGroupPrivate;
		private global::Gtk.CheckButton checkGroupStatic;
		private global::Gtk.Table tableEval;
		private global::Gtk.Label label3;
		private global::Gtk.Label labelEvalTimeout;
		private global::Gtk.SpinButton spinTimeout;
		private global::Gtk.Label label4;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label labelPriorityList;
		private global::MonoDevelop.Ide.Gui.Components.PriorityList prioritylist;
		private global::Gtk.Label labelPreferredDebuggers;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Debugger.DebuggerOptionsPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Debugger.DebuggerOptionsPanelWidget";
			// Container child MonoDevelop.Debugger.DebuggerOptionsPanelWidget.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(9));
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkProjectCodeOnly = new global::Gtk.CheckButton ();
			this.checkProjectCodeOnly.CanFocus = true;
			this.checkProjectCodeOnly.Name = "checkProjectCodeOnly";
			this.checkProjectCodeOnly.Label = global::Mono.Unix.Catalog.GetString ("Debug project code only; do not step into framework code.");
			this.checkProjectCodeOnly.Active = true;
			this.checkProjectCodeOnly.DrawIndicator = true;
			this.checkProjectCodeOnly.UseUnderline = true;
			this.vbox3.Add (this.checkProjectCodeOnly);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.checkProjectCodeOnly]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkStepOverPropertiesAndOperators = new global::Gtk.CheckButton ();
			this.checkStepOverPropertiesAndOperators.CanFocus = true;
			this.checkStepOverPropertiesAndOperators.Name = "checkStepOverPropertiesAndOperators";
			this.checkStepOverPropertiesAndOperators.Label = global::Mono.Unix.Catalog.GetString ("Step over properties and operators");
			this.checkStepOverPropertiesAndOperators.Active = true;
			this.checkStepOverPropertiesAndOperators.DrawIndicator = true;
			this.checkStepOverPropertiesAndOperators.UseUnderline = true;
			this.vbox3.Add (this.checkStepOverPropertiesAndOperators);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.checkStepOverPropertiesAndOperators]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkAllowEval = new global::Gtk.CheckButton ();
			this.checkAllowEval.CanFocus = true;
			this.checkAllowEval.Name = "checkAllowEval";
			this.checkAllowEval.Label = global::Mono.Unix.Catalog.GetString ("Allow implicit property evaluation and method invocation");
			this.checkAllowEval.Active = true;
			this.checkAllowEval.DrawIndicator = true;
			this.checkAllowEval.UseUnderline = true;
			this.vbox3.Add (this.checkAllowEval);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.checkAllowEval]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignmentAllowToString = new global::Gtk.Alignment (0F, 0.5F, 1F, 1F);
			this.alignmentAllowToString.Name = "alignmentAllowToString";
			this.alignmentAllowToString.LeftPadding = ((uint)(18));
			// Container child alignmentAllowToString.Gtk.Container+ContainerChild
			this.checkAllowToString = new global::Gtk.CheckButton ();
			this.checkAllowToString.CanFocus = true;
			this.checkAllowToString.Name = "checkAllowToString";
			this.checkAllowToString.Label = global::Mono.Unix.Catalog.GetString ("Call string-conversion function on objects in variables windows");
			this.checkAllowToString.Active = true;
			this.checkAllowToString.DrawIndicator = true;
			this.checkAllowToString.UseUnderline = true;
			this.alignmentAllowToString.Add (this.checkAllowToString);
			this.vbox3.Add (this.alignmentAllowToString);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignmentAllowToString]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkAllowTypeLoad = new global::Gtk.CheckButton ();
			this.checkAllowTypeLoad.CanFocus = true;
			this.checkAllowTypeLoad.Name = "checkAllowTypeLoad";
			this.checkAllowTypeLoad.Label = global::Mono.Unix.Catalog.GetString ("Allow implicitly invoking static constructors on types");
			this.checkAllowTypeLoad.Active = true;
			this.checkAllowTypeLoad.DrawIndicator = true;
			this.checkAllowTypeLoad.UseUnderline = true;
			this.vbox3.Add (this.checkAllowTypeLoad);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.checkAllowTypeLoad]));
			w6.Position = 4;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkShowBaseGroup = new global::Gtk.CheckButton ();
			this.checkShowBaseGroup.CanFocus = true;
			this.checkShowBaseGroup.Name = "checkShowBaseGroup";
			this.checkShowBaseGroup.Label = global::Mono.Unix.Catalog.GetString ("Show inherited class members in a base class group");
			this.checkShowBaseGroup.DrawIndicator = true;
			this.checkShowBaseGroup.UseUnderline = true;
			this.vbox3.Add (this.checkShowBaseGroup);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.checkShowBaseGroup]));
			w7.Position = 5;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkGroupPrivate = new global::Gtk.CheckButton ();
			this.checkGroupPrivate.CanFocus = true;
			this.checkGroupPrivate.Name = "checkGroupPrivate";
			this.checkGroupPrivate.Label = global::Mono.Unix.Catalog.GetString ("Group non-public members");
			this.checkGroupPrivate.DrawIndicator = true;
			this.checkGroupPrivate.UseUnderline = true;
			this.vbox3.Add (this.checkGroupPrivate);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.checkGroupPrivate]));
			w8.Position = 6;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkGroupStatic = new global::Gtk.CheckButton ();
			this.checkGroupStatic.CanFocus = true;
			this.checkGroupStatic.Name = "checkGroupStatic";
			this.checkGroupStatic.Label = global::Mono.Unix.Catalog.GetString ("Group static members");
			this.checkGroupStatic.DrawIndicator = true;
			this.checkGroupStatic.UseUnderline = true;
			this.vbox3.Add (this.checkGroupStatic);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.checkGroupStatic]));
			w9.Position = 7;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.tableEval = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
			this.tableEval.Name = "tableEval";
			this.tableEval.RowSpacing = ((uint)(6));
			this.tableEval.ColumnSpacing = ((uint)(6));
			// Container child tableEval.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("ms");
			this.tableEval.Add (this.label3);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableEval [this.label3]));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableEval.Gtk.Table+TableChild
			this.labelEvalTimeout = new global::Gtk.Label ();
			this.labelEvalTimeout.Name = "labelEvalTimeout";
			this.labelEvalTimeout.Xalign = 0F;
			this.labelEvalTimeout.LabelProp = global::Mono.Unix.Catalog.GetString ("Evaluation Timeout:");
			this.tableEval.Add (this.labelEvalTimeout);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableEval [this.labelEvalTimeout]));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableEval.Gtk.Table+TableChild
			this.spinTimeout = new global::Gtk.SpinButton (0, 1000000, 100);
			this.spinTimeout.CanFocus = true;
			this.spinTimeout.Name = "spinTimeout";
			this.spinTimeout.Adjustment.PageIncrement = 10;
			this.spinTimeout.ClimbRate = 100;
			this.spinTimeout.Numeric = true;
			this.tableEval.Add (this.spinTimeout);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableEval [this.spinTimeout]));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.tableEval);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.tableEval]));
			w13.Position = 8;
			w13.Expand = false;
			w13.Fill = false;
			this.notebook1.Add (this.vbox3);
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("General");
			this.notebook1.SetTabLabel (this.vbox3, this.label4);
			this.label4.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelPriorityList = new global::Gtk.Label ();
			this.labelPriorityList.WidthRequest = 417;
			this.labelPriorityList.Name = "labelPriorityList";
			this.labelPriorityList.Xalign = 0F;
			this.labelPriorityList.LabelProp = global::Mono.Unix.Catalog.GetString ("This priority list will be used when selecting the engine to be used for debugging an application.");
			this.labelPriorityList.Wrap = true;
			this.vbox2.Add (this.labelPriorityList);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelPriorityList]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.prioritylist = new global::MonoDevelop.Ide.Gui.Components.PriorityList ();
			this.prioritylist.Name = "prioritylist";
			this.vbox2.Add (this.prioritylist);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.prioritylist]));
			w16.Position = 1;
			this.notebook1.Add (this.vbox2);
			global::Gtk.Notebook.NotebookChild w17 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox2]));
			w17.Position = 1;
			// Notebook tab
			this.labelPreferredDebuggers = new global::Gtk.Label ();
			this.labelPreferredDebuggers.Name = "labelPreferredDebuggers";
			this.labelPreferredDebuggers.LabelProp = global::Mono.Unix.Catalog.GetString ("Preferred Debuggers");
			this.notebook1.SetTabLabel (this.vbox2, this.labelPreferredDebuggers);
			this.labelPreferredDebuggers.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.checkAllowEval.Toggled += new global::System.EventHandler (this.OnCheckAllowEvalToggled);
		}
	}
}
