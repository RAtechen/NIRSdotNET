
// This file has been generated by the GUI designer. Do not modify.
namespace NIRSrecorder
{
	public partial class ConnectDevices
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Frame frame3;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.CheckButton checkbutton_simMode;

		private global::Gtk.Label label1;

		private global::Gtk.SpinButton spinbutton_numSimDevices;

		private global::Gtk.Label GtkLabel9;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.VBox vbox_devices;

		private global::Gtk.Frame frame6;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.HBox hbox14;

		private global::Gtk.ComboBox combobox_avail;

		private global::Gtk.Button button_connect;

		private global::Gtk.Button button_ident;

		private global::Gtk.Label GtkLabel4;

		private global::Gtk.Frame frame8;

		private global::Gtk.Alignment GtkAlignment3;

		private global::Gtk.HBox hbox13;

		private global::Gtk.ComboBox combobox_connected;

		private global::Gtk.Button button_discont;

		private global::Gtk.Button button234;

		private global::Gtk.Label GtkLabel7;

		private global::Gtk.Frame frame10;

		private global::Gtk.Alignment GtkAlignment4;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textview_info;

		private global::Gtk.Label GtkLabel8;

		private global::Gtk.Label GtkLabel1;

		private global::Gtk.Button buttonCancel;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget NIRSrecorder.ConnectDevices
			this.Name = "NIRSrecorder.ConnectDevices";
			this.Title = global::Mono.Unix.Catalog.GetString("Connect Devices");
			this.WindowPosition = ((global::Gtk.WindowPosition)(2));
			this.BorderWidth = ((uint)(13));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DestroyWithParent = true;
			// Internal child NIRSrecorder.ConnectDevices.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame();
			this.frame3.Name = "frame3";
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.checkbutton_simMode = new global::Gtk.CheckButton();
			this.checkbutton_simMode.CanFocus = true;
			this.checkbutton_simMode.Name = "checkbutton_simMode";
			this.checkbutton_simMode.Label = global::Mono.Unix.Catalog.GetString("Use Data Simulator");
			this.checkbutton_simMode.Active = true;
			this.checkbutton_simMode.DrawIndicator = true;
			this.checkbutton_simMode.UseUnderline = true;
			this.hbox1.Add(this.checkbutton_simMode);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.checkbutton_simMode]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("# devices");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.spinbutton_numSimDevices = new global::Gtk.SpinButton(1D, 5D, 1D);
			this.spinbutton_numSimDevices.CanFocus = true;
			this.spinbutton_numSimDevices.Name = "spinbutton_numSimDevices";
			this.spinbutton_numSimDevices.Adjustment.PageIncrement = 10D;
			this.spinbutton_numSimDevices.ClimbRate = 1D;
			this.spinbutton_numSimDevices.Numeric = true;
			this.spinbutton_numSimDevices.Value = 1D;
			this.hbox1.Add(this.spinbutton_numSimDevices);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.spinbutton_numSimDevices]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.GtkAlignment1.Add(this.hbox1);
			this.frame3.Add(this.GtkAlignment1);
			this.GtkLabel9 = new global::Gtk.Label();
			this.GtkLabel9.Name = "GtkLabel9";
			this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Simulator Mode</b>");
			this.GtkLabel9.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel9;
			this.vbox2.Add(this.frame3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.frame3]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox_devices = new global::Gtk.VBox();
			this.vbox_devices.Name = "vbox_devices";
			this.vbox_devices.Spacing = 6;
			this.vbox_devices.BorderWidth = ((uint)(5));
			// Container child vbox_devices.Gtk.Box+BoxChild
			this.frame6 = new global::Gtk.Frame();
			this.frame6.Name = "frame6";
			this.frame6.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame6.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.hbox14 = new global::Gtk.HBox();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.combobox_avail = global::Gtk.ComboBox.NewText();
			this.combobox_avail.AppendText(global::Mono.Unix.Catalog.GetString("---------------------"));
			this.combobox_avail.Name = "combobox_avail";
			this.combobox_avail.Active = 0;
			this.hbox14.Add(this.combobox_avail);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.combobox_avail]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.button_connect = new global::Gtk.Button();
			this.button_connect.CanFocus = true;
			this.button_connect.Name = "button_connect";
			this.button_connect.UseUnderline = true;
			this.button_connect.Label = global::Mono.Unix.Catalog.GetString("Connect");
			this.hbox14.Add(this.button_connect);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.button_connect]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.button_ident = new global::Gtk.Button();
			this.button_ident.CanFocus = true;
			this.button_ident.Name = "button_ident";
			this.button_ident.UseUnderline = true;
			this.button_ident.Label = global::Mono.Unix.Catalog.GetString("Identify");
			this.hbox14.Add(this.button_ident);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.button_ident]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.GtkAlignment2.Add(this.hbox14);
			this.frame6.Add(this.GtkAlignment2);
			this.GtkLabel4 = new global::Gtk.Label();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Avaliable Devices</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame6.LabelWidget = this.GtkLabel4;
			this.vbox_devices.Add(this.frame6);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox_devices[this.frame6]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox_devices.Gtk.Box+BoxChild
			this.frame8 = new global::Gtk.Frame();
			this.frame8.Name = "frame8";
			this.frame8.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame8.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.hbox13 = new global::Gtk.HBox();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.combobox_connected = global::Gtk.ComboBox.NewText();
			this.combobox_connected.AppendText(global::Mono.Unix.Catalog.GetString("---------------------"));
			this.combobox_connected.Name = "combobox_connected";
			this.combobox_connected.Active = 0;
			this.hbox13.Add(this.combobox_connected);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.combobox_connected]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.button_discont = new global::Gtk.Button();
			this.button_discont.CanFocus = true;
			this.button_discont.Name = "button_discont";
			this.button_discont.UseUnderline = true;
			this.button_discont.Label = global::Mono.Unix.Catalog.GetString("Disconnect");
			this.hbox13.Add(this.button_discont);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.button_discont]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.button234 = new global::Gtk.Button();
			this.button234.CanFocus = true;
			this.button234.Name = "button234";
			this.button234.UseUnderline = true;
			this.button234.Label = global::Mono.Unix.Catalog.GetString("Identify");
			this.hbox13.Add(this.button234);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.button234]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.GtkAlignment3.Add(this.hbox13);
			this.frame8.Add(this.GtkAlignment3);
			this.GtkLabel7 = new global::Gtk.Label();
			this.GtkLabel7.Name = "GtkLabel7";
			this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Connected Devices</b>");
			this.GtkLabel7.UseMarkup = true;
			this.frame8.LabelWidget = this.GtkLabel7;
			this.vbox_devices.Add(this.frame8);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox_devices[this.frame8]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox_devices.Gtk.Box+BoxChild
			this.frame10 = new global::Gtk.Frame();
			this.frame10.Name = "frame10";
			this.frame10.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame10.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			this.GtkAlignment4.LeftPadding = ((uint)(12));
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview_info = new global::Gtk.TextView();
			this.textview_info.CanFocus = true;
			this.textview_info.Name = "textview_info";
			this.textview_info.Editable = false;
			this.GtkScrolledWindow.Add(this.textview_info);
			this.GtkAlignment4.Add(this.GtkScrolledWindow);
			this.frame10.Add(this.GtkAlignment4);
			this.GtkLabel8 = new global::Gtk.Label();
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString("<b>System</b>");
			this.GtkLabel8.UseMarkup = true;
			this.frame10.LabelWidget = this.GtkLabel8;
			this.vbox_devices.Add(this.frame10);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox_devices[this.frame10]));
			w23.Position = 2;
			this.GtkAlignment.Add(this.vbox_devices);
			this.frame1.Add(this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Collection Devices</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel1;
			this.vbox2.Add(this.frame1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.frame1]));
			w26.Position = 1;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w27.Position = 0;
			// Internal child NIRSrecorder.ConnectDevices.ActionArea
			global::Gtk.HButtonBox w28 = this.ActionArea;
			w28.Name = "dialog1_ActionArea";
			w28.Spacing = 10;
			w28.BorderWidth = ((uint)(5));
			w28.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Accept");
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w29 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w28[this.buttonCancel]));
			w29.Expand = false;
			w29.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 352;
			this.Show();
			this.checkbutton_simMode.Toggled += new global::System.EventHandler(this.ToggleUseSim);
			this.button_connect.Clicked += new global::System.EventHandler(this.Cont);
			this.button_ident.Clicked += new global::System.EventHandler(this.IDdiscont);
			this.button_discont.Clicked += new global::System.EventHandler(this.Discont);
			this.button234.Clicked += new global::System.EventHandler(this.IDcont);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.ClickedOK);
		}
	}
}
