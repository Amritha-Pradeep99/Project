<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="EmployeeGridInsert.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 112px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Name</td>
            <td>
                <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Gender</td>
            <td>
                <asp:RadioButtonList ID="rblgender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Dept</td>
            <td>
                <asp:DropDownList ID="ddldept" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Salary</td>
            <td>
                <asp:TextBox ID="txtsalary" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" Width="100px" />
                <asp:Button ID="btnshow" runat="server" OnClick="btnshow_Click" Text="show" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:GridView ID="gddetails" runat="server" ShowFooter="True"  AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowCommand="gddetails_RowCommand" DataKeyNames="empid" OnSelectedIndexChanged="gddetails_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#DCDCDC"  />
                    <Columns>
                        <asp:TemplateField HeaderText="Name">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%#Bind("empname") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblna" runat="server" Text='<%#Bind("empname") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtna" runat="server" Text='<%#Bind("empname") %>'></asp:TextBox>
                            </FooterTemplate>

                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Gender">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%#Bind("empgender") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblgend" runat="server" Text='<%#Bind("empgender") %>'></asp:Label>
                            </ItemTemplate>
                          <FooterTemplate>
                              <asp:RadioButtonList ID="rblgend" runat="server" RepeatDirection="Horizontal">
                                  <asp:ListItem >Male</asp:ListItem>
                                  <asp:ListItem>Female</asp:ListItem>
                              </asp:RadioButtonList>
                            
                          </FooterTemplate>

                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Dept">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%#Bind("empdept") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbldep" runat="server" Text='<%#Bind("empdept") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList ID="ddldep" runat="server" width="100" Height="16">
                                    <asp:ListItem>CS</asp:ListItem>
                                    <asp:ListItem>EC</asp:ListItem>
                                    <asp:ListItem>IT</asp:ListItem>
                                </asp:DropDownList>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Salary">
                             <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%#Bind("empsalary") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblsal" runat="server" Text='<%#Bind("empsalary") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtsal" runat="server" Text='<%#Bind("empsalary") %>'></asp:TextBox>
                            </FooterTemplate>

                        </asp:TemplateField>
                       <asp:TemplateField>
                           <ItemTemplate>
                               <asp:Button ID="btndelete" runat="server" Text="Delete" CommandName="del" CommandArgument='<%#Eval("empid") %>' />
                           </ItemTemplate>
                           <FooterTemplate>
                               <asp:Button ID="btnsave" runat="server" Text="Save" CommandName="save"/>
                           </FooterTemplate>
                       </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

