using System;
namespace SSLMaker
{
	public partial class SSLDetails : Gtk.Dialog
	{
		protected virtual void onCancel_clicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		
		public SSLDetails ()
		{
			this.Build ();
		}
	}
}

