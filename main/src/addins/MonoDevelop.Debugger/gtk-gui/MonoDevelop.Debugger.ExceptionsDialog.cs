
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Debugger
{
	public partial class ExceptionsDialog
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label2;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Image image15;
		private global::Gtk.Entry entryFilter;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeExceptions;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label label1;
		private global::Gtk.Button buttonAdd;
		private global::Gtk.Button buttonRemove;
		private global::Gtk.Label label4;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView treeSelected;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Debugger.ExceptionsDialog
			this.Name = "MonoDevelop.Debugger.ExceptionsDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Exceptions");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(3));
			// Internal child MonoDevelop.Debugger.ExceptionsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(9));
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Exceptions:");
			this.vbox4.Add (this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image15 = new global::Gtk.Image ();
			this.image15.Name = "image15";
			this.image15.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-find", global::Gtk.IconSize.Menu);
			this.hbox2.Add (this.image15);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.image15]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryFilter = new global::Gtk.Entry ();
			this.entryFilter.CanFocus = true;
			this.entryFilter.Name = "entryFilter";
			this.entryFilter.IsEditable = true;
			this.entryFilter.InvisibleChar = '●';
			this.hbox2.Add (this.entryFilter);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryFilter]));
			w4.Position = 1;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeExceptions = new global::Gtk.TreeView ();
			this.treeExceptions.CanFocus = true;
			this.treeExceptions.Name = "treeExceptions";
			this.treeExceptions.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.treeExceptions);
			this.vbox4.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow]));
			w7.Position = 2;
			this.hbox1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox4]));
			w8.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 12;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.vbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label1]));
			w9.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button ();
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseUnderline = true;
			this.buttonAdd.Label = "";
			global::Gtk.Image w10 = new global::Gtk.Image ();
			w10.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Menu);
			this.buttonAdd.Image = w10;
			this.vbox3.Add (this.buttonAdd);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.buttonAdd]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonRemove = new global::Gtk.Button ();
			this.buttonRemove.CanFocus = true;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.UseUnderline = true;
			this.buttonRemove.Label = "";
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-back", global::Gtk.IconSize.Menu);
			this.buttonRemove.Image = w12;
			this.vbox3.Add (this.buttonRemove);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.buttonRemove]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.vbox3.Add (this.label4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label4]));
			w14.Position = 3;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Stop in exceptions:");
			this.vbox5.Add (this.label3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label3]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeSelected = new global::Gtk.TreeView ();
			this.treeSelected.CanFocus = true;
			this.treeSelected.Name = "treeSelected";
			this.treeSelected.HeadersVisible = false;
			this.GtkScrolledWindow1.Add (this.treeSelected);
			this.vbox5.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow1]));
			w18.Position = 1;
			this.hbox1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox5]));
			w19.Position = 2;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w20.Position = 0;
			// Internal child MonoDevelop.Debugger.ExceptionsDialog.ActionArea
			global::Gtk.HButtonBox w21 = this.ActionArea;
			w21.Name = "dialog1_ActionArea";
			w21.Spacing = 6;
			w21.BorderWidth = ((uint)(5));
			w21.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w21 [this.buttonCancel]));
			w22.Expand = false;
			w22.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w23 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w21 [this.buttonOk]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 910;
			this.DefaultHeight = 451;
			this.Hide ();
			this.entryFilter.Changed += new global::System.EventHandler (this.OnEntryFilterChanged);
			this.entryFilter.Activated += new global::System.EventHandler (this.OnEntryFilterActivated);
			this.treeExceptions.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnTreeExceptionsKeyPressEvent);
			this.treeExceptions.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnTreeExceptionsButtonPressEvent);
			this.buttonAdd.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
			this.buttonRemove.Clicked += new global::System.EventHandler (this.OnButtonRemoveClicked);
			this.treeSelected.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnTreeSelectedKeyPressEvent);
			this.treeSelected.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnTreeSelectedButtonPressEvent);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
