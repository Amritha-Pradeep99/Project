<%@ Page Title="" Language="C#" MasterPageFile="~/NewUserStoredProcedure/NewUserStoredProcedureMasterPage.master" AutoEventWireup="true" CodeFile="ViewNewUser.aspx.cs" Inherits="NewUserStoredProcedure_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gdUserView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="gdUserView_PageIndexChanging">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="nu_fname" HeaderText="Fname" />
                        <asp:BoundField DataField="nu_lname" HeaderText="Lname" />
                        <asp:BoundField DataField="nu_gender" HeaderText="Gender" />
                        <asp:BoundField DataField="nu_martial" HeaderText="Martial" />
                        <asp:BoundField DataField="nu_qual" HeaderText="Qual" />
                        <asp:BoundField DataField="nu_email" HeaderText="Email" />
                        <asp:BoundField DataField="nu_address" HeaderText="Address" />
                        <asp:BoundField DataField="nu_phone" HeaderText="Contact" />
                        <asp:BoundField DataField="nu_usern" HeaderText="Username" />
                        <asp:BoundField DataField="nu_pwd" HeaderText="Password" />
                        <asp:BoundField DataField="district_name" HeaderText="District" />
                        <asp:BoundField DataField="place_name" HeaderText="Place" />
                        <asp:TemplateField HeaderText="Photo">
                            <ItemTemplate>
                                <img src="../Assests/UserDocs/<%#Eval("nu_photo") %>" width="50" height="40" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Proof">
                            <ItemTemplate>
                                <img src="../Assests/UserDocs/<%#Eval("nu_proof") %>" width="50" height="40" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

