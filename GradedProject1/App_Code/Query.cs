using System;
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

using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


public static class Query
{

    public static address Get_Address(string filterName,
                                      out string error_msg)
    {
        SqlDataReader rdr = null;
        SqlConnection cn = null;
        address adr = null;
        error_msg = "";
        try
        {
            cn = Setup_Connection();
            rdr = Get_Reader(filterName, cn);

       
            //if (rdr.Read())
            while(rdr.Read())
            {
                //every loop save into a data collection then populate dropdownlist in main class 
                error_msg = "Lookup success! Val is:" + (string)rdr["CompanyName"] +
                    " CompanyId is " + (string)rdr["CustomerID"]; 
            }
            //else
            //{
            //    error_msg = "Lookup failed";
            //}
        }
        catch (Exception ex)
        {
            error_msg = "ERROR: " + ex.Message;
        }

        finally
        {
            if (rdr != null)
            {
                rdr.Close();
            }

            if (cn != null)
            {
                cn.Close();
            }
        }
        return adr;
    }


    private static SqlConnection Setup_Connection()
    {
        String connection_string =
WebConfigurationManager.ConnectionStrings["AddressTable"].ConnectionString;

        SqlConnection cn = new SqlConnection(connection_string);

        cn.Open();
        return cn;
    }



    private static SqlDataReader Get_Reader(string filterName,
                                        SqlConnection cn)
    {
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "SELECT CompanyName, CustomerID FROM Customers " +
                          "WHERE CompanyName LIKE "+"'"+filterName.ToString()+"%'";
        cmd.Parameters.AddWithValue("@filterName",
                                      filterName);

        cmd.Connection = cn;
        return cmd.ExecuteReader();
    }


}

