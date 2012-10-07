using System;
namespace SSLMaker
{
	public partial class UserDetails : Gtk.Dialog
	{
		public static uDetails ud = new uDetails("GB","North Yorkshire","Scarborough","Claymarda","IT Dept","david@localhost");

		protected virtual void onCancel_clicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
				
		public UserDetails ()
		{
			this.Build ();
			
			ebUDCountry.Text=ud.Country;
			ebUDState.Text=ud.State;
			ebUDLocality.Text=ud.Locality;
			ebUDOrgName.Text=ud.OrgName;
			ebUDOrgUnit.Text=ud.OrgUnit;
			ebUDEmail.Text=ud.Email;
		}
		
		protected virtual void onSave_clicked (object sender, System.EventArgs e)
		{
			ud.Country=ebUDCountry.Text;			
			ud.State=ebUDState.Text;
			ud.Locality=ebUDLocality.Text;
			ud.OrgName=ebUDOrgName.Text;
			ud.OrgUnit=ebUDOrgUnit.Text;
			ud.Email=ebUDEmail.Text;
			this.Destroy();
		}
	}
	
	public class uDetails
	{
		private string sz_UDCountry;
		public string Country{ get{return sz_UDCountry;}set{sz_UDCountry = value;}}

		private string sz_UDState;
		public string State{ get{return sz_UDState;}set{sz_UDState = value;}}

		private string sz_UDLocality;
		public string Locality{ get{return sz_UDLocality;}set{sz_UDLocality = value;}}
		
		private string sz_UDOrgName;
		public string OrgName{ get{return sz_UDOrgName;}set{sz_UDOrgName = value;}}

		public string sz_UDOrgUnit;
		public string OrgUnit{ get{return sz_UDOrgUnit;}set{sz_UDOrgUnit = value;}}
		
		private string sz_UDEmail;
		public string Email{ get{return sz_UDEmail;}set{sz_UDEmail = value;}}	
		
		public uDetails(string country, string state, string locality,
		                string orgname, string orgunit, string email)
		{
			sz_UDEmail= email;
			sz_UDCountry=country;
			sz_UDLocality=locality;
			sz_UDOrgName=orgname;
			sz_UDOrgUnit=orgunit;
			sz_UDState=state;
		}
	}

}
