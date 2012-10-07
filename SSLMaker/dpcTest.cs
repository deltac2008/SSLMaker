using System;
namespace SSLMaker
{
	public partial class dpcTest : Gtk.Dialog
	{
		double progressValue=0;
		
		public dpcTest ()
		{
			this.Build ();
			ebOutput.Text=SSLMaker.UserDetails.ud.Country;
		}
		
		
		protected virtual void OnButton74Clicked (object sender, System.EventArgs e)
		{
			this.progressbar2.Pulse();
		}
		
		protected virtual void OnButtonCancelClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		protected virtual void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		protected virtual void onBtnDownClicked (object sender, System.EventArgs e)
		{
			this.progressValue -= .1;
			if(this.progressValue < 0) this.progressValue = 0;
			this.progressbar3.Fraction = this.progressValue;
		}
		
		protected virtual void onBtnUpClicked (object sender, System.EventArgs e)
		{
			this.progressValue += .1;
			if(this.progressValue > 1) this.progressValue = 1;
			this.progressbar3.Fraction = this.progressValue;
		}
	}
}

