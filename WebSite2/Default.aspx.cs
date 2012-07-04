using System;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        tbLastName.Text = "";
        tbFirstName.Text = "";
        tbAddress1.Text = "";
        tbAddress2.Text = "";
        tbCity.Text = "";
        tbState.Text = "";
        tbZipCode.Text = "";


    }

    protected void btnLookup_Click(object sender, EventArgs e)
    {
        string error_msg;
        Address adr = Query.Get_Address(tbInput.Text,
                                        out error_msg);
        if (adr != null)
        {
            Display_Results(adr);
        }
        lblMessage.Text = error_msg;

    }

    protected void Display_Results(Address adr)
    {
        tbLastName.Text = adr.Last_name;
        tbFirstName.Text = adr.First_name;
        tbAddress1.Text = adr.Address1;
        tbAddress2.Text = adr.Address2;
        tbCity.Text = adr.City;
        tbState.Text = adr.State;
        tbZipCode.Text = adr.Zip_code;
    }

}
