using System;

namespace SSLMaker
{
	public partial class CheckDisk : Gtk.Dialog
	{
		public CheckDisk ()
		{
			this.Build ();
			tbCommand.Text = "ls";
			tbParams.Text = "-la";
			tvResults.Buffer.Text = "Running...";
		}
		
		protected virtual void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		protected virtual void OnButtonCancelClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		protected virtual void OnBtnExecuteClicked (object sender, System.EventArgs e)
		{
			//string szError;
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			
			try
			{
				proc.EnableRaisingEvents=false;
				proc.StartInfo.UseShellExecute=false;
				proc.StartInfo.RedirectStandardOutput=true;
				proc.StartInfo.FileName=tbCommand.Text; // "openssl";
				proc.StartInfo.Arguments=tbParams.Text; //"genrsa";
				proc.Start();
				tvResults.Buffer.Text = proc.StandardOutput.ReadToEnd();
				
				proc.WaitForExit();
			}
			catch
			{
				//szError = "Problem with process!";
			}
		}
		
		
		
		
	}
}

