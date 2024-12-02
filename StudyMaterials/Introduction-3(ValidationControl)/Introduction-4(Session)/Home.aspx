<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Introduction_4_Login_Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {            color: #FF0000;
        }
        .style3
        {
            width: 106px;
        }
        .style4
        {
            font-weight: bold;
            color: #FF0000;
        }
        .style5
        {
            color: #FF0000;
            width: 95px;
        }
        .style6
        {
            width: 95px;
        }
        .style7
        {
            font-weight: bold;
            color: #FF0000;
            width: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    <strong>Session</strong></td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style2">
                    <asp:LinkButton ID="lnkLogout" runat="server" onclick="lnkLogout_Click">Logout</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Welcome</td>
                <td class="style6">
                    <asp:Label ID="lblwelcome" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
