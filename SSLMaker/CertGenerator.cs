using System;
using System.IO;
using System.Diagnostics;

namespace SSLMaker
{
	public partial class CertGenerator : Gtk.Dialog
	{
		public static certDetails cd = new certDetails("common.name");
		
		public CertGenerator ()
		{
			this.Build ();
			lblCommonName.Text=cd.CommonName;
		}		
		
		protected virtual void OnButtonCancelClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		protected virtual void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			// generate destination fileand path
			string destFilename = SSLMaker.Preferences.userPrefs.CertFile+"/"+lblCommonName.Text;
			
			// run shell command
			Process.Start("touch", destFilename);
			
			this.Destroy();
		}
	}
	
	public class certDetails
	{
		private string sz_cdCommonName;
		public string CommonName{ get{return sz_cdCommonName;}set{sz_cdCommonName = value;}}

		public certDetails(string cn)
		{
			sz_cdCommonName= cn;
		}
	}
}

