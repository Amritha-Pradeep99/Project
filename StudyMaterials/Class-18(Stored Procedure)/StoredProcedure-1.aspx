<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StoredProcedure-1.aspx.cs" Inherits="Class_18_Stored_Procedure_StoredProcedure" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">



        .style1
        {
            width: 100%;
        }
        .style6
        {
            color: #FF0000;
            font-size: large;
        }
        .style7
        {
        }
        .style8
        {
            width: 153px;
            color: #FF0000;
            font-size: large;
            text-decoration: underline;
        }
        .style9
        {
            color: #FF0000;
        }
        .style10
        {
            width: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style7" colspan="3">
                    <table class="style1">
                        <tr>
                            <td class="style8">
                                <strong>Stored Procedure</strong></td>
                        </tr>
        </table>
    
                </td>
            </tr>
            <tr>
                <td class="style9" colspan="2">
                    <strong>SelectDataBase---Programmability---StoredProcedure---NewStoredProcedure</strong></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
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
                <td class="style10">
                    Dept</td>
                <td>
                    <asp:DropDownList ID="ddldept" runat="server" Height="16px" Width="119px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    Salary</td>
                <td>
                    <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                    
                    <asp:Button ID="btnShow" runat="server" Text="Show" onclick="btnShow_Click" 
                        style="width: 48px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style6">
                    <asp:GridView ID="grdDetails" runat="server" AutoGenerateColumns="False" 
                        style="color: #000000; font-size: medium" DataKeyNames="empid" 
                        
                        onrowcommand="grdDetails_RowCommand" BackColor="LightGoldenrodYellow" 
                        BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
                        GridLines="None" onrowdeleting="grdDetails_RowDeleting" 
                       >
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        <Columns>
                            <asp:BoundField DataField="empname" HeaderText="Name" />
                            <asp:BoundField DataField="empgender" HeaderText="Gender" />
                            <asp:BoundField DataField="empdept" HeaderText="Department" />
                            <asp:BoundField DataField="empsalary" HeaderText="Salary" />
                            <asp:CommandField ShowDeleteButton="True" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="Button2" runat="server" Text="edit" CommandName="edt" CommandArgument='<%# Eval("empid") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                            HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                        <SortedAscendingCellStyle BackColor="#FAFAE7" />
                        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                        <SortedDescendingCellStyle BackColor="#E1DB9C" />
                        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
