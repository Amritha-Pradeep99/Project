<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TableControl-1.aspx.cs" Inherits="Class_25_TableControl_TableControl_1" %>

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
        {
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                RollNumber</td>
            <td>
                <asp:TextBox ID="txtroll" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
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
                Mark</td>
            <td>
                <asp:TextBox ID="txtmark" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
               <asp:Table ID="Table1" runat="server" BorderColor="DarkGreen" BorderWidth="1">  
                <asp:TableHeaderRow ForeColor="SeaGreen">  
                    <asp:TableHeaderCell>RollNumber</asp:TableHeaderCell>  
                    <asp:TableHeaderCell>Name</asp:TableHeaderCell>  
                    <asp:TableHeaderCell>Mark</asp:TableHeaderCell>  
                </asp:TableHeaderRow>  
               
                <asp:TableRow>  
                    <asp:TableCell>1</asp:TableCell>  
                    <asp:TableCell>ss</asp:TableCell>  
                    <asp:TableCell>33</asp:TableCell>
                </asp:TableRow>  
                
                </asp:Table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
