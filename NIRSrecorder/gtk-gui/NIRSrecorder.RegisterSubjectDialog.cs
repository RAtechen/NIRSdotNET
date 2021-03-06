
// This file has been generated by the GUI designer. Do not modify.
namespace NIRSrecorder
{
	public partial class RegisterSubjectDialog
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox6;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Fixed fixed12;

		private global::Gtk.Button button67;

		private global::Gtk.Frame frame5;

		private global::Gtk.Alignment GtkAlignment4;

		private global::Gtk.VBox vbox8;

		private global::Gtk.Label label6;

		private global::Gtk.ComboBox combobox_investigators;

		private global::Gtk.Label label8;

		private global::Gtk.ComboBox combobox_studies;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label_hypersacan;

		private global::Gtk.ComboBox combobox_hyperscanning;

		private global::Gtk.Label GtkLabel4;

		private global::Gtk.Frame frame7;

		private global::Gtk.Alignment GtkAlignment5;

		private global::Gtk.Table table1;

		private global::Gtk.ComboBoxEntry comboboxentry_subjID;

		private global::Gtk.Entry demo_age;

		private global::Gtk.ComboBoxEntry demo_gender;

		private global::Gtk.Entry demo_group;

		private global::Gtk.Entry demo_headsize;

		private global::Gtk.Entry demo_tecnician;

		private global::Gtk.Label label10;

		private global::Gtk.Label label12;

		private global::Gtk.Label label14;

		private global::Gtk.Label label16;

		private global::Gtk.Label label18;

		private global::Gtk.Label label20;

		private global::Gtk.Label GtkLabel6;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.DrawingArea drawingarea1;

		private global::Gtk.Label GtkLabel3;

		private global::Gtk.Frame frame3;

		private global::Gtk.Alignment GtkAlignment3;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView demo_comments;

		private global::Gtk.Label GtkLabel5;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Fixed fixed8;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget NIRSrecorder.RegisterSubjectDialog
			this.Name = "NIRSrecorder.RegisterSubjectDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child NIRSrecorder.RegisterSubjectDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.fixed12 = new global::Gtk.Fixed();
			this.fixed12.Name = "fixed12";
			this.fixed12.HasWindow = false;
			this.hbox3.Add(this.fixed12);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.fixed12]));
			w2.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button67 = new global::Gtk.Button();
			this.button67.CanFocus = true;
			this.button67.Name = "button67";
			this.button67.UseUnderline = true;
			this.button67.Label = global::Mono.Unix.Catalog.GetString("Load Probe");
			this.hbox3.Add(this.button67);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.button67]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox6.Add(this.hbox3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.frame5 = new global::Gtk.Frame();
			this.frame5.Name = "frame5";
			// Container child frame5.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			this.GtkAlignment4.LeftPadding = ((uint)(12));
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.vbox8 = new global::Gtk.VBox();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 3;
			this.vbox8.BorderWidth = ((uint)(16));
			// Container child vbox8.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Investigator");
			this.vbox8.Add(this.label6);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.label6]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.combobox_investigators = global::Gtk.ComboBox.NewText();
			this.combobox_investigators.Name = "combobox_investigators";
			this.vbox8.Add(this.combobox_investigators);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.combobox_investigators]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Study");
			this.vbox8.Add(this.label8);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.label8]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.combobox_studies = global::Gtk.ComboBox.NewText();
			this.combobox_studies.Name = "combobox_studies";
			this.vbox8.Add(this.combobox_studies);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.combobox_studies]));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label_hypersacan = new global::Gtk.Label();
			this.label_hypersacan.Name = "label_hypersacan";
			this.label_hypersacan.LabelProp = global::Mono.Unix.Catalog.GetString("Device ID");
			this.hbox4.Add(this.label_hypersacan);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label_hypersacan]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.combobox_hyperscanning = global::Gtk.ComboBox.NewText();
			this.combobox_hyperscanning.AppendText(global::Mono.Unix.Catalog.GetString("Device-1"));
			this.combobox_hyperscanning.Name = "combobox_hyperscanning";
			this.combobox_hyperscanning.Active = 0;
			this.hbox4.Add(this.combobox_hyperscanning);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.combobox_hyperscanning]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox8.Add(this.hbox4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox4]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			this.GtkAlignment4.Add(this.vbox8);
			this.frame5.Add(this.GtkAlignment4);
			this.GtkLabel4 = new global::Gtk.Label();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Select Study</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame5.LabelWidget = this.GtkLabel4;
			this.vbox6.Add(this.frame5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.frame5]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.frame7 = new global::Gtk.Frame();
			this.frame7.Name = "frame7";
			// Container child frame7.Gtk.Container+ContainerChild
			this.GtkAlignment5 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment5.Name = "GtkAlignment5";
			this.GtkAlignment5.LeftPadding = ((uint)(12));
			this.GtkAlignment5.BorderWidth = ((uint)(10));
			// Container child GtkAlignment5.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(6)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxentry_subjID = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry_subjID.Name = "comboboxentry_subjID";
			this.table1.Add(this.comboboxentry_subjID);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxentry_subjID]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.demo_age = new global::Gtk.Entry();
			this.demo_age.CanFocus = true;
			this.demo_age.Name = "demo_age";
			this.demo_age.IsEditable = true;
			this.demo_age.InvisibleChar = '●';
			this.table1.Add(this.demo_age);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.demo_age]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.demo_gender = global::Gtk.ComboBoxEntry.NewText();
			this.demo_gender.AppendText(global::Mono.Unix.Catalog.GetString("Female"));
			this.demo_gender.AppendText(global::Mono.Unix.Catalog.GetString("Male"));
			this.demo_gender.AppendText(global::Mono.Unix.Catalog.GetString("Other"));
			this.demo_gender.Name = "demo_gender";
			this.demo_gender.Active = 0;
			this.table1.Add(this.demo_gender);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.demo_gender]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.demo_group = new global::Gtk.Entry();
			this.demo_group.CanFocus = true;
			this.demo_group.Name = "demo_group";
			this.demo_group.IsEditable = true;
			this.demo_group.InvisibleChar = '●';
			this.table1.Add(this.demo_group);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.demo_group]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.demo_headsize = new global::Gtk.Entry();
			this.demo_headsize.CanFocus = true;
			this.demo_headsize.Name = "demo_headsize";
			this.demo_headsize.IsEditable = true;
			this.demo_headsize.InvisibleChar = '●';
			this.table1.Add(this.demo_headsize);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.demo_headsize]));
			w19.TopAttach = ((uint)(4));
			w19.BottomAttach = ((uint)(5));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.demo_tecnician = new global::Gtk.Entry();
			this.demo_tecnician.CanFocus = true;
			this.demo_tecnician.Name = "demo_tecnician";
			this.demo_tecnician.IsEditable = true;
			this.demo_tecnician.InvisibleChar = '●';
			this.table1.Add(this.demo_tecnician);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.demo_tecnician]));
			w20.TopAttach = ((uint)(5));
			w20.BottomAttach = ((uint)(6));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Subject ID");
			this.table1.Add(this.label10);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.label10]));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Group");
			this.table1.Add(this.label12);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.label12]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("Gender");
			this.table1.Add(this.label14);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.label14]));
			w23.TopAttach = ((uint)(2));
			w23.BottomAttach = ((uint)(3));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("Age");
			this.table1.Add(this.label16);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.label16]));
			w24.TopAttach = ((uint)(3));
			w24.BottomAttach = ((uint)(4));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("Head Circ.");
			this.table1.Add(this.label18);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.label18]));
			w25.TopAttach = ((uint)(4));
			w25.BottomAttach = ((uint)(5));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("Technician");
			this.table1.Add(this.label20);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1[this.label20]));
			w26.TopAttach = ((uint)(5));
			w26.BottomAttach = ((uint)(6));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment5.Add(this.table1);
			this.frame7.Add(this.GtkAlignment5);
			this.GtkLabel6 = new global::Gtk.Label();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Demographics</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame7.LabelWidget = this.GtkLabel6;
			this.vbox6.Add(this.frame7);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.frame7]));
			w29.Position = 2;
			w29.Expand = false;
			w29.Fill = false;
			this.hbox1.Add(this.vbox6);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox6]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox1.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator1]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.HeightRequest = 170;
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment2.WidthRequest = 221;
			this.GtkAlignment2.HeightRequest = 92;
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.drawingarea1 = new global::Gtk.DrawingArea();
			this.drawingarea1.Name = "drawingarea1";
			this.GtkAlignment2.Add(this.drawingarea1);
			this.frame1.Add(this.GtkAlignment2);
			this.GtkLabel3 = new global::Gtk.Label();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Probe</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel3;
			this.vbox4.Add(this.frame1);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.frame1]));
			w34.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.demo_comments = new global::Gtk.TextView();
			this.demo_comments.CanFocus = true;
			this.demo_comments.Name = "demo_comments";
			this.GtkScrolledWindow.Add(this.demo_comments);
			this.GtkAlignment3.Add(this.GtkScrolledWindow);
			this.frame3.Add(this.GtkAlignment3);
			this.GtkLabel5 = new global::Gtk.Label();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Comments</b>");
			this.GtkLabel5.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel5;
			this.vbox4.Add(this.frame3);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.frame3]));
			w38.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed8 = new global::Gtk.Fixed();
			this.fixed8.Name = "fixed8";
			this.fixed8.HasWindow = false;
			this.hbox2.Add(this.fixed8);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.fixed8]));
			w39.Position = 0;
			this.vbox4.Add(this.hbox2);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
			w40.Position = 2;
			w40.Expand = false;
			w40.Fill = false;
			this.hbox1.Add(this.vbox4);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox4]));
			w41.Position = 2;
			w41.Expand = false;
			w41.Fill = false;
			w1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(w1[this.hbox1]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Internal child NIRSrecorder.RegisterSubjectDialog.ActionArea
			global::Gtk.HButtonBox w43 = this.ActionArea;
			w43.Name = "dialog1_ActionArea";
			w43.Spacing = 10;
			w43.BorderWidth = ((uint)(5));
			w43.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w44 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w43[this.buttonCancel]));
			w44.Expand = false;
			w44.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w45 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w43[this.buttonOk]));
			w45.Position = 1;
			w45.Expand = false;
			w45.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 543;
			this.DefaultHeight = 517;
			this.Show();
			this.button67.Clicked += new global::System.EventHandler(this.LoadProbeClicked);
			this.combobox_investigators.Changed += new global::System.EventHandler(this.InvestigatorChanged);
			this.combobox_studies.Changed += new global::System.EventHandler(this.StudyChanged);
			this.combobox_hyperscanning.Changed += new global::System.EventHandler(this.SelectDevice);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.RegisterCancel);
			this.buttonOk.Clicked += new global::System.EventHandler(this.RegisterAccept);
		}
	}
}
