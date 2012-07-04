using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


public static class Query
{

    public static Address Get_Address(string last_name,
                                      out string error_msg)
    {
        SqlDataReader rdr = null;
        SqlConnection cn = null;
        Address adr = null;
        error_msg = "";
        try
        {
            cn = Setup_Connection();
            rdr = Get_Reader(last_name, cn);

            // Process Query Result
            if (rdr.Read())
            {
                adr = new Address(rdr);
            }
            else
            {
                error_msg = "Lookup failed";
            }
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



    private static SqlDataReader Get_Reader(string last_name,
                                        SqlConnection cn)
    {
        SqlCommand cmd = new SqlCommand();
        //cmd.CommandText = "SELECT * FROM Addresses " +
        //                  "WHERE Last_Name='" + last_name + "'";

        cmd.CommandText = "SELECT * FROM Addresses " +
                          "WHERE Last_Name=@last_name";

        cmd.Parameters.AddWithValue("@last_name",
                                     last_name);
        cmd.Connection = cn;
        return cmd.ExecuteReader();
    }


}

