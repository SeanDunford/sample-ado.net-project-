﻿using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    private requestedCompanyInformation mQueriedCollection = null;//address really should have been called NorthwIND info or something more related
    private int mCounter = -1;
    private string mNameInput = "";
    private int mOrders;                 //should have been orderNumbers or amountOfOrders
    private string mErrorMessage;
    protected void Page_Load(object sender, EventArgs e)
    {
        uCompanyNameFilter.Focus();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

        uNameDropDown.Items.Clear();
        uNameDropDown.Items.Add("Select Customer");
        mNameInput = uCompanyNameFilter.Text.Trim();
        mNameInput = mNameInput.Replace("\'", "\'\'");
        mQueriedCollection = Query.Get_requestedCompanyInformation(mNameInput, out  mErrorMessage);
        mCounter = mQueriedCollection.howMany();
        uError.Text =  mErrorMessage;
        uNameDropDown.Enabled = true;

        if (Session["mQueriedCollection"] != null)
        {
            Session["mQueriedCollection"] = null;
        }

        if (mCounter > -1)                                  //could this ever be -1? 
        {
            if (mCounter == 0)
            {
                uNameDropDown.Enabled = false;
                uError.Text = "There are no customer names matching " + uCompanyNameFilter.Text.ToString() + ".";
                //left htis as text box info and not the string var because "b     '" 
                //was printing as just "b". It still delimits some white space but it 
                //includes special chars after whitespace now. 
            }
            else if (mCounter == 1)
            {
                mOrders = Query.Get_Orders(mQueriedCollection.getId(0), out  mErrorMessage);
                uNameDropDown.Enabled = false;
                uError.Text = mQueriedCollection.getName(0) + " has " + mOrders.ToString() + " Orders. ";
            }
            else
            {
                for (int i = 0; i < mCounter; i++)
                {
                    uNameDropDown.Items.Add(mQueriedCollection.getName(i));
                }
            }

        }
        if (Session["mQueriedCollection"] == null)
        {
            Session["mQueriedCollection"] = mQueriedCollection;
        }
    }

    protected void ddlNames_SelectedIndexChanged(object sender, EventArgs e)
    {
        mQueriedCollection = (requestedCompanyInformation)Session["mQueriedCollection"];
        if (uNameDropDown.SelectedIndex >= 1)
        {
            mOrders = Query.Get_Orders(mQueriedCollection.getId(uNameDropDown.SelectedIndex - 1), out  mErrorMessage);
            uError.Text = mQueriedCollection.getName(uNameDropDown.SelectedIndex - 1) + " has " + mOrders.ToString() + " Orders. ";
        }
        else
            uError.Text = "";
    }


}