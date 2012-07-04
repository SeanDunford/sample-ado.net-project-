using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;


public class requestedCompanyInformation
{
    private List<string> mCompanyName = new List<string>();
    private List<string> mCompanyId = new List<string>();            //i should have used a dictionary instead                                                                   //getID[customerName] more intutive then selected mIndex manipulation
    private List<string> mOrders = new List<string>();
    private int mIndex = -1; 

	public requestedCompanyInformation()
	{
        	
	}
    public void addToRequestedCompanyInformation(string aCompanyName, string aCompanyIdNumber)
    {
        mIndex++;
        mCompanyName.Add(aCompanyName);
        mCompanyId.Add(aCompanyIdNumber);
         
    }
    public string getName(int aLocalIndex)
        {
            return mCompanyName[aLocalIndex]; 
        }
    public string getId(int aLocalIndex)
    {
        return mCompanyId[aLocalIndex];
    }
    public int howMany()
    {
        return mIndex +1; 
    }
}
