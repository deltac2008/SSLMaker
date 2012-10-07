using System;
namespace SSLMaker
{
	public partial class About : Gtk.Dialog
	{
		public About ()
		{
			this.Build ();
		}

		protected virtual void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			this.Destroy ();
		}
	}
}

