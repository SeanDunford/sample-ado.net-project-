using System;
using System.Data.SqlClient;

public class Address
{
    private int id;
    public int Id
    {
        get { return id; }
    }

    private string last_name;
    public string Last_name
    {
        get { return last_name; }
        set { last_name = value; }
    }

    private string first_name;
    public string First_name
    {
        get { return first_name; }
        set { first_name = value; }
    }

    private string address1;
    public string Address1
    {
        get { return address1; }
        set { address1 = value; }
    }

    private string address2;
    public string Address2
    {
        get { return address2; }
        set { address2 = value; }
    }

    private string city;
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    private string state;
    public string State
    {
        get { return state; }
        set { state = value; }
    }

    private String zip_code;
    public String Zip_code
    {
        get { return zip_code; }
        set { zip_code = value; }
    }

    public Address(SqlDataReader rdr)
    {
        id = (int)rdr["ID"];
        last_name = (string)rdr["Last_Name"];
        first_name = (string)rdr["First_Name"];
        address1 = (string)rdr["Address1"];
        address2 = (string)rdr["Address2"];
        city = (string)rdr["City"];
        state = (string)rdr["State"];
        zip_code = (string)rdr["Zip_Code"];
    }

}