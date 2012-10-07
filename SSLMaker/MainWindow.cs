using System;
using Gtk;
using System.IO;
using GLib;

public partial class MainWindow : Gtk.Window
{
	/*
	Our globally accessible variables...
		SSLMaker.UserDetails.ud.Country
		SSLMaker.UserDetails.ud.State
		SSLMaker.UserDetails.ud.Locality
		SSLMaker.UserDetails.ud.OrgName
		SSLMaker.UserDetails.ud.OrgUnit
		SSLMaker.UserDetails.ud.Email
		SSLMaker.Preferences.userPrefs.CertFile
		SSLMaker.Preferences.userPrefs.KeyFile
	 */
	
	//public static certDetails cd = new certDetails("common.name");
	
	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
		displayMessage("Welcome!");
		ebCommonName.Text=SSLMaker.CertGenerator.cd.CommonName;
		lblKeyFileLocation.Text=SSLMaker.Preferences.userPrefs.KeyFile;
		lblCertFileLocation.Text=SSLMaker.Preferences.userPrefs.CertFile;
		btnGenerateCert.GrabFocus();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected virtual void onMainWinDone_clicked (object sender, System.EventArgs e)
	{
		Application.Quit();
	}
	
	protected virtual void onFileQuit_clicked (object sender, System.EventArgs e)
	{
		Application.Quit();
	}
	
	protected virtual void onGenerateKey_clicked (object sender, System.EventArgs e)
	{
		SSLMaker.KeyCreate dlgCreateKey = new SSLMaker.KeyCreate();
		dlgCreateKey.Show();		
	}
	
	protected virtual void onGenerateCertificate_clicked (object sender, System.EventArgs e)
	{
		//SSLMaker.dpcTest dlgTest = new SSLMaker.dpcTest();
		//dlgTest.Show();
		SSLMaker.CertGenerator dlgCertGen = new SSLMaker.CertGenerator();
		dlgCertGen.Show();
	}
	
	protected virtual void onEditUserDetails_clicked (object sender, System.EventArgs e)
	{
		SSLMaker.UserDetails dlgUserDetails = new SSLMaker.UserDetails();
		dlgUserDetails.Show();
	}
	
	protected virtual void onEditPreferences_clicked (object sender, System.EventArgs e)
	{
		SSLMaker.Preferences dlgPreferences = new SSLMaker.Preferences();
		dlgPreferences.Show();
	}

	protected virtual void OnSavePrefsActionActivated (object sender, System.EventArgs e)
	{
		TextWriter tw = new StreamWriter("prefs.txt");
		
		tw.WriteLine(SSLMaker.UserDetails.ud.Country);
		tw.WriteLine(SSLMaker.UserDetails.ud.State);
		tw.WriteLine(SSLMaker.UserDetails.ud.Locality);
		tw.WriteLine(SSLMaker.UserDetails.ud.OrgName);
		tw.WriteLine(SSLMaker.UserDetails.ud.OrgUnit);
		tw.WriteLine(SSLMaker.UserDetails.ud.Email);
		tw.WriteLine(SSLMaker.Preferences.userPrefs.CertFile);
		tw.WriteLine(SSLMaker.Preferences.userPrefs.KeyFile);
		
		tw.Close();
		displayMessage("Prefs saved!");

	}
	
	protected virtual void OnLoadPrefsActionActivated (object sender, System.EventArgs e)
	{
		TextReader tr = new StreamReader("prefs.txt");
		
		SSLMaker.UserDetails.ud.Country = tr.ReadLine();
		SSLMaker.UserDetails.ud.State = tr.ReadLine();
		SSLMaker.UserDetails.ud.Locality = tr.ReadLine();
		SSLMaker.UserDetails.ud.OrgName = tr.ReadLine();
		SSLMaker.UserDetails.ud.OrgUnit = tr.ReadLine();
		SSLMaker.UserDetails.ud.Email = tr.ReadLine();
		SSLMaker.Preferences.userPrefs.CertFile = tr.ReadLine();
		SSLMaker.Preferences.userPrefs.KeyFile = tr.ReadLine();
		             
		tr.Close();
		displayMessage("Prefs loaded");
	}
	
	protected virtual void OnClearStatusBarActionActivated(object sender, System.EventArgs e)
	{
		// cannot remove this funtion???
	}
	protected virtual void OnRubbishActionActivated(object sender, System.EventArgs e)
	{
		// cannot remove this function???
	}
	
	protected virtual void displayMessage(string msg)
	{
		statusbar1.Pop(1); statusbar1.Push(1,msg);
		GLib.Timeout.Add(2000, new GLib.TimeoutHandler (clearStatusBar) );
	}
	
	bool clearStatusBar()
	{
		statusbar1.Pop(1);
		return true;
	}
	
	protected virtual void OnAboutActionActivated (object sender, System.EventArgs e)
	{
		SSLMaker.About dlgAbout = new SSLMaker.About();
		dlgAbout.Show();
		//SSLMaker.directoryTools dlgA = new SSLMaker.directoryTools();
		//dlgA.Show();
	}
	
	protected virtual void OnStripPassphraseActionActivated (object sender, System.EventArgs e)
	{
		SSLMaker.KeyStripPass dlgStripPass = new SSLMaker.KeyStripPass();
		dlgStripPass.Show();
	}
	
	protected virtual void OnWorkingDirectoryActionActivated (object sender, System.EventArgs e)
	{
		SSLMaker.directoryTools dlgdirTools = new SSLMaker.directoryTools();
		dlgdirTools.Show();
	}
	
	protected virtual void OnViewCertificateActionActivated (object sender, System.EventArgs e)
	{
	}
	
	protected virtual void OnCheckDiskActionActivated (object sender, System.EventArgs e)
	{
		SSLMaker.CheckDisk dlgcd = new SSLMaker.CheckDisk();
		dlgcd.Show();
	}
	
	
	
	
	protected void OnEbCommonNameChanged (object sender, System.EventArgs e)
	{
		///@throw new System.NotImplementedException ();
		SSLMaker.CertGenerator.cd.CommonName=ebCommonName.Text;
	}
}
