using System;
namespace SSLMaker
{
	public partial class KeyStripPass : Gtk.Dialog
	{
		public KeyStripPass ()
		{
			this.Build ();
		}

		protected virtual void OnButtonCancelClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
				
		protected virtual void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		
	}
}

