using System;
using System.IO;
using System.Diagnostics;

namespace SSLMaker
{
	public partial class KeyCreate : Gtk.Dialog
	{
		public KeyCreate ()
		{
			this.Build ();
			ebFilename.Text=SSLMaker.CertGenerator.cd.CommonName + ".key";
			ebPassphrase.GrabFocus();			
		}
		
		protected virtual void onDlgCancel_clicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}		
		
		protected virtual void onDlgOk_clicked (object sender, System.EventArgs e)
		{
			// verify directories exist
			string szKeySize = "2048";
			if (rbKeySize1.Active) szKeySize = "1024";
			
			// generate key using openssl
			string destFilename = SSLMaker.Preferences.userPrefs.KeyFile+"/"+ebFilename.Text;
			
			// run shell command
			Process.Start("openssl", "genrsa -out "+ destFilename + " " + szKeySize);
			
			
			// close dlg window
			this.Destroy();
		}		
	}
}

