
// This file has been generated by the GUI designer. Do not modify.
namespace SSLMaker
{
	public partial class SSLDetails
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label1;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label7;
		private global::Gtk.HSeparator hseparator3;
		private global::Gtk.VBox vbox7;
		private global::Gtk.HBox hbox13;
		private global::Gtk.Label label13;
		private global::Gtk.Entry entry10;
		private global::Gtk.HBox hbox12;
		private global::Gtk.Label label14;
		private global::Gtk.Entry entry9;
		private global::Gtk.HBox hbox7;
		private global::Gtk.Label label15;
		private global::Gtk.Entry entry4;
		private global::Gtk.HBox hbox8;
		private global::Gtk.Label label9;
		private global::Gtk.Entry entry5;
		private global::Gtk.HBox hbox10;
		private global::Gtk.Label label10;
		private global::Gtk.Entry entry6;
		private global::Gtk.HBox hbox9;
		private global::Gtk.Label label8;
		private global::Gtk.Entry entry7;
		private global::Gtk.VBox vbox4;
		private global::Gtk.HBox hbox11;
		private global::Gtk.Label label11;
		private global::Gtk.Entry entry8;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget SSLMaker.SSLDetails
			this.Name = "SSLMaker.SSLDetails";
			this.Title = "";
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("SSLMaker.images.padlockandkeys16x16.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child SSLMaker.SSLDetails.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>SSL Details Entry Dialog</b>");
			this.label1.UseMarkup = true;
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(4));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox2.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator2]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter the required details in the fields below.\nThese will be stored for use in later requests for certificates and keys.");
			this.label7.Wrap = true;
			this.label7.Justify = ((global::Gtk.Justification)(2));
			this.vbox5.Add (this.label7);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label7]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.vbox5.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hseparator3]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox ();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.WidthRequest = 192;
			this.label13.Name = "label13";
			this.label13.Xalign = 1F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Country Name (C):");
			this.hbox13.Add (this.label13);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.label13]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.entry10 = new global::Gtk.Entry ();
			this.entry10.CanFocus = true;
			this.entry10.Name = "entry10";
			this.entry10.IsEditable = true;
			this.entry10.InvisibleChar = '•';
			this.hbox13.Add (this.entry10);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.entry10]));
			w7.Position = 1;
			this.vbox7.Add (this.hbox13);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox13]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox ();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label ();
			this.label14.WidthRequest = 192;
			this.label14.Name = "label14";
			this.label14.Xalign = 1F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("State or Province Name (ST):");
			this.hbox12.Add (this.label14);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label14]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.entry9 = new global::Gtk.Entry ();
			this.entry9.CanFocus = true;
			this.entry9.Name = "entry9";
			this.entry9.IsEditable = true;
			this.entry9.InvisibleChar = '•';
			this.hbox12.Add (this.entry9);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.entry9]));
			w10.Position = 1;
			this.vbox7.Add (this.hbox12);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox12]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label ();
			this.label15.WidthRequest = 192;
			this.label15.Name = "label15";
			this.label15.Xalign = 1F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Locality Name (L):");
			this.hbox7.Add (this.label15);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label15]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.entry4 = new global::Gtk.Entry ();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.InvisibleChar = '•';
			this.hbox7.Add (this.entry4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entry4]));
			w13.Position = 1;
			this.vbox7.Add (this.hbox7);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox7]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.WidthRequest = 192;
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Organisation (O):");
			this.hbox8.Add (this.label9);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label9]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.entry5 = new global::Gtk.Entry ();
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.InvisibleChar = '•';
			this.hbox8.Add (this.entry5);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.entry5]));
			w16.Position = 1;
			this.vbox7.Add (this.hbox8);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox8]));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox ();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.WidthRequest = 192;
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Organisational Unit (OU):");
			this.hbox10.Add (this.label10);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.label10]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.entry6 = new global::Gtk.Entry ();
			this.entry6.CanFocus = true;
			this.entry6.Name = "entry6";
			this.entry6.IsEditable = true;
			this.entry6.InvisibleChar = '•';
			this.hbox10.Add (this.entry6);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.entry6]));
			w19.Position = 1;
			this.vbox7.Add (this.hbox10);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox10]));
			w20.Position = 4;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.WidthRequest = 192;
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Common Name (CN):");
			this.hbox9.Add (this.label8);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label8]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.entry7 = new global::Gtk.Entry ();
			this.entry7.CanFocus = true;
			this.entry7.Name = "entry7";
			this.entry7.IsEditable = true;
			this.entry7.InvisibleChar = '•';
			this.hbox9.Add (this.entry7);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.entry7]));
			w22.Position = 1;
			this.vbox7.Add (this.hbox9);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox9]));
			w23.Position = 5;
			w23.Expand = false;
			w23.Fill = false;
			this.vbox5.Add (this.vbox7);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vbox7]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox2.Add (this.vbox5);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox5]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox ();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.WidthRequest = 192;
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Email Address (E):");
			this.hbox11.Add (this.label11);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.label11]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.entry8 = new global::Gtk.Entry ();
			this.entry8.CanFocus = true;
			this.entry8.Name = "entry8";
			this.entry8.IsEditable = true;
			this.entry8.InvisibleChar = '•';
			this.hbox11.Add (this.entry8);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.entry8]));
			w27.Position = 1;
			this.vbox4.Add (this.hbox11);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox11]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox4.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hseparator1]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox2.Add (this.vbox4);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox4]));
			w30.Position = 3;
			w30.Expand = false;
			w30.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Internal child SSLMaker.SSLDetails.ActionArea
			global::Gtk.HButtonBox w32 = this.ActionArea;
			w32.Name = "dialog1_ActionArea";
			w32.Spacing = 10;
			w32.BorderWidth = ((uint)(5));
			w32.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w33 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w34 = new global::Gtk.HBox ();
			w34.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w35 = new global::Gtk.Image ();
			w35.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w34.Add (w35);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w37 = new global::Gtk.Label ();
			w37.LabelProp = global::Mono.Unix.Catalog.GetString ("_Cancel");
			w37.UseUnderline = true;
			w34.Add (w37);
			w33.Add (w34);
			this.buttonCancel.Add (w33);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w41 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w32 [this.buttonCancel]));
			w41.Expand = false;
			w41.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w42 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w43 = new global::Gtk.HBox ();
			w43.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w44 = new global::Gtk.Image ();
			w44.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w43.Add (w44);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w46 = new global::Gtk.Label ();
			w46.LabelProp = global::Mono.Unix.Catalog.GetString ("_Save");
			w46.UseUnderline = true;
			w43.Add (w46);
			w42.Add (w43);
			this.buttonOk.Add (w42);
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w50 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w32 [this.buttonOk]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 548;
			this.DefaultHeight = 415;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.onCancel_clicked);
		}
	}
}
