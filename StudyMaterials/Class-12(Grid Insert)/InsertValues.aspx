<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsertValues.aspx.cs" Inherits="Class_12_Grid_Insert_InsertValues" %>

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
                    <strong>Insert Values in Grid</strong></td>
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
                    <br />
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
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style6">
                    <asp:GridView ID="grdDetails" runat="server" AutoGenerateColumns="False" 
                        style="color: #000000; font-size: medium" DataKeyNames="empid" 
                        
                        onrowcommand="grdDetails_RowCommand" BackColor="LightGoldenrodYellow" 
                        BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
                        GridLines="None" ShowFooter="True" 
                        onselectedindexchanged="grdDetails_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" /> 
                        <Columns>

                            <asp:TemplateField HeaderText="Name">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("empname") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblna" runat="server" Text='<%# Bind("empname") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                  <asp:TextBox ID="txtna" runat="server" Text='<%# Bind("empname") %>'></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Gender">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("empgender") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblgen" runat="server" Text='<%# Bind("empgender") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:RadioButtonList ID="rdbgen" runat="server" RepeatDirection="Horizontal">
                                        <asp:ListItem>Male</asp:ListItem>
                                        <asp:ListItem>Female</asp:ListItem>
                                    </asp:RadioButtonList>
                                </FooterTemplate>

                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Department">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("empdept") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbldept" runat="server" Text='<%# Bind("empdept") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                  <asp:DropDownList ID="ddldep" runat="server" Height="16px" Width="124px">
                                    <asp:ListItem>CS</asp:ListItem>
                                    <asp:ListItem>EC</asp:ListItem>
                                    <asp:ListItem>IT</asp:ListItem>
                                  </asp:DropDownList>
                                </FooterTemplate>

                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Salary">
                            
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("empsalary") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblsal" runat="server" Text='<%# Bind("empsalary") %>'></asp:Label>
                                </ItemTemplate>
                                 <FooterTemplate>
                                  <asp:TextBox ID="txtsal" runat="server" Text='<%# Bind("empsalary") %>'></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="btndel" CommandName="del" CommandArgument='<%# Eval("empid") %>' runat="server" Text="delete" />
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:Button ID="btnsave" CommandName="save"  runat="server" Text="Save" />
                                </FooterTemplate>
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
