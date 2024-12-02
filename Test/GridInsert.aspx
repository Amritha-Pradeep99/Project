<%@ Page Title="" Language="C#" MasterPageFile="~/Test/TestMaster.master" AutoEventWireup="true" CodeFile="GridInsert.aspx.cs" Inherits="Test_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 113px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Name</td>
            <td>
                <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Gender</td>
            <td>
                <asp:RadioButtonList ID="rblgender" runat="server" RepeatDirection="Horizontal" Width="200px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Dept</td>
            <td>
                <asp:DropDownList ID="ddldept" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Salary</td>
            <td>
                <asp:TextBox ID="txtsalary" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
                <asp:Button ID="btnshow" runat="server" Text="Show" OnClick="btnshow_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:GridView ID="grdDetails" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="5" DataKeyNames="empid" ForeColor="Black" GridLines="Vertical"  ShowFooter="True"  
                      OnRowCommand="grdDetails_RowCommand"   PageSize="5">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
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
                                    <asp:ListItem>CSE</asp:ListItem>
                                    <asp:ListItem>IT</asp:ListItem>
                                    <asp:ListItem>ME</asp:ListItem>
                                    <asp:ListItem>EEE</asp:ListItem>
                                    <asp:ListItem>ECE</asp:ListItem>
                                    <asp:ListItem>CS</asp:ListItem>
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
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="Gray" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

