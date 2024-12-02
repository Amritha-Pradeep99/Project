<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LiteralExample.aspx.cs" Inherits="Class_10_LiteralExample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">




        .style1
        {
            width: 100%;
        }
        .style3
        {
            text-decoration: underline;
            color: #FF0000;
        }
        .style2
        {
            width: 19px;
        }
        .style6
        {
            color: #FF0000;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3" colspan="3">
                    <strong>Literal Example</strong></td>
            </tr>
            <tr>
                <td class="style2">
                    Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Gender</td>
                <td>
                    <asp:RadioButtonList ID="rdbgender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Dept</td>
                <td>
                    <asp:DropDownList ID="ddldept" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Salary</td>
                <td>
                    <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                    <asp:Button ID="btnShow" runat="server" Text="Show" onclick="btnShow_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    ID</td>
                <td class="style6">
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" 
                        onclick="btnSearch_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style6">
                    <asp:Literal ID="ltrlEmployee" runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
