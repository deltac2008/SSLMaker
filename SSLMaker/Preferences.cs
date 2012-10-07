using System;
namespace SSLMaker
{
	public partial class Preferences : Gtk.Dialog
	{
		public static uPrefs userPrefs = new uPrefs("/home/david/SSLMaker/Keys/","/home/david/SSLMaker/Certs/");
		
		public Preferences ()
		{
			this.Build ();
			ebKeyFile.Text=userPrefs.KeyFile;
			ebCertFile.Text=userPrefs.CertFile;
		}
		
		protected virtual void onCancel_clicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		protected virtual void onSave_clicked (object sender, System.EventArgs e)
		{
			userPrefs.KeyFile=ebKeyFile.Text;
			userPrefs.CertFile=ebCertFile.Text;
			this.Destroy();
		}		
	}
	
	public class uPrefs
	{
		private string sz_uKeyFile;
		public string KeyFile{ get{return sz_uKeyFile;}set{sz_uKeyFile = value;}}

		private string sz_uCertFile;
		public string CertFile{ get{return sz_uCertFile;}set{sz_uCertFile = value;}}

		public uPrefs(string kfile, string cfile)
		{
			sz_uKeyFile= kfile;
			sz_uCertFile=cfile;
		}
	}
	
}

