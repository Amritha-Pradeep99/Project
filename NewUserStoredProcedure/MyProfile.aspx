<%@ Page Title="" Language="C#" MasterPageFile="~/NewUserStoredProcedure/NewUserStoredProcedureMasterPage.master" AutoEventWireup="true" CodeFile="MyProfile.aspx.cs" Inherits="NewUserStoredProcedure_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
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
            <td class="auto-style2">
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" Height="50px" Width="125px">
                    <Fields>
                        <asp:BoundField DataField="nu_fname" HeaderText="Fname" />
                        <asp:BoundField DataField="nu_lname" HeaderText="Lname" />
                        <asp:BoundField DataField="nu_gender" HeaderText="Gender" />
                        <asp:BoundField DataField="nu_martial" HeaderText="Martial" />
                        <asp:BoundField DataField="nu_qual" HeaderText="Qual" />
                        <asp:BoundField DataField="nu_email" HeaderText="Email" />
                        <asp:BoundField DataField="nu_address" HeaderText="Address" />
                        <asp:BoundField DataField="district_name" HeaderText="District" />
                        <asp:BoundField DataField="place_name" HeaderText="Place" />
                        <asp:BoundField DataField="nu_phone" HeaderText="Contact" />
                        <asp:BoundField DataField="nu_usern" HeaderText="Username" />
                        <asp:BoundField DataField="nu_pwd" HeaderText="Password" />
                        <asp:TemplateField HeaderText="Photo">
                            <ItemTemplate>
                                <img src="../Assests/UserDocs/<%#Eval("nu_photo") %>" width="50" height="50" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Proof">
                            <ItemTemplate>
                                <img src="../Assests/UserDocs/<%#Eval("nu_proof") %>" width="50" height="50" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Fields>
                </asp:DetailsView>
            </td>
            <td class="auto-style2"></td>
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

