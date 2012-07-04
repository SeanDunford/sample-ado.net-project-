<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HULK, SCIENTIST!!! WHAT YOU KNOW?</title>
</head>
<body>
    <form id="form1" runat="server">
    <center>
    <div>
    
        <asp:Label ID="uTitleLabel" runat="server" Text="Northwind Traders orders" 
            BackColor="White" Font-Bold="True" Font-Size="XX-Large" ForeColor="Blue" 
            Font-Names="Arial Black"></asp:Label>
        <br />
        <br />
        <table cellspacing="5">
        <tr>
        <td align="left"> 
            <asp:Label ID="uCompanyName" runat="server" Text="Company Name" 
                Font-Names="Arial"></asp:Label>
            </td>
        <td></td>
        </tr>
        <tr>
        <td align="left">
            <asp:Label ID="uInstruction" runat="server" Text="One or more initial letters" 
                Font-Names="Arial"></asp:Label>
            </td>
        <td></td>
        </tr>
        <tr>
        <td>
            <asp:TextBox ID="uCompanyNameFilter" runat="server" AutoPostBack="True" Width="175px" 
                ontextchanged="TextBox1_TextChanged"></asp:TextBox>
            </td>
        <td>
            <asp:DropDownList ID="uNameDropDown" runat="server" Width="175px" 
                AutoPostBack="True" onselectedindexchanged="ddlNames_SelectedIndexChanged">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="Select Customer"></asp:ListItem>
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
        <td colspan="2">
  
          <center>  <asp:Label ID="uError" runat="server" Font-Names="Arial"></asp:Label> </center>
    </td>
    </tr>

      </table>
          <br />
    </div>
     </center>
    </form>
</body>
</html>
