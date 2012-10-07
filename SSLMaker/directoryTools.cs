using System;
namespace SSLMaker
{
	public partial class directoryTools : Gtk.Dialog
	{
		public directoryTools ()
		{
			this.Build ();
			buttonOk.Sensitive=false;
			KeyFileOutput.Text=SSLMaker.Preferences.userPrefs.KeyFile;
			KeyFileOutput.Sensitive=false;
			CertFileOutput.Text=SSLMaker.Preferences.userPrefs.CertFile;
			CertFileOutput.Sensitive=false;
		}

		protected virtual void OnButtonCancelClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
				
		
		protected virtual void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			// save any new details
			this.Destroy();
		}
		
		protected virtual void OnButton393Clicked (object sender, System.EventArgs e)
		{
			if(KeyFileOutput.Sensitive)
			{
				// hit cancel button
				button393.Label="Change";
				KeyFileOutput.Sensitive=false;
			}
			else
			{
				// cancel cert file field
				button394.Label="Change";
				CertFileOutput.Sensitive=false;
				
				KeyFileOutput.Sensitive=true;
				button393.Label="Cancel";
				buttonOk.Sensitive=true;
			}
			SSLMaker.fileBrowser dlgfb = new SSLMaker.fileBrowser();
			dlgfb.Show();
		}
		
		protected virtual void OnButton394Clicked (object sender, System.EventArgs e)
		{
			if(CertFileOutput.Sensitive)
			{
				// hit cancel button
				button394.Label="Change";
				CertFileOutput.Sensitive=false;
			}
			else
			{
				// cancel key file field
				button393.Label="Change";
				KeyFileOutput.Sensitive=false;
				
				CertFileOutput.Sensitive=true;
				button394.Label="Cancel";
				buttonOk.Sensitive=true;
			}
		}
	}
}

