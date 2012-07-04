<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Address Lookup</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Last Name"></asp:Label>
        &nbsp; &nbsp;
        <asp:TextBox ID="tbInput" runat="server" Width="158px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="tbInput" ErrorMessage="Last name is required for lookup"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnLookup" runat="server" Text="Lookup Address" 
            onclick="btnLookup_Click" />
        &nbsp;
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Address1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbAddress1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Address2"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbAddress2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="City"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="State"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbState" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Zip Code"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbZipCode" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
