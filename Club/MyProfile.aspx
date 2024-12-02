<%@ Page Title="" Language="C#" MasterPageFile="~/Club/ClubMaster.master" AutoEventWireup="true" CodeFile="MyProfile.aspx.cs" Inherits="Club_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 227px;
        }
         .move {
            margin-top: 80px;
        }
    .auto-style3 {
            width: 314px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="move" >
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style2">
                <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
                    <Fields>
                        <asp:BoundField DataField="nc_name" HeaderText="Name" />
                        <asp:BoundField DataField="nc_email" HeaderText="Email" />
                        <asp:BoundField DataField="nc_contact" HeaderText="Contact" />
                        <asp:BoundField DataField="nc_username" HeaderText="UserName" />
                        <asp:BoundField DataField="nc_pwd" HeaderText="Password" />
                        <asp:BoundField DataField="nc_address" HeaderText="Address" />
                        <asp:BoundField DataField="nc_date" HeaderText="Starting Date" />
                        <asp:TemplateField HeaderText="Photo">
                            <ItemTemplate>
                                <img src="../Assests/Clubdoc/<%#Eval("nc_photo") %>" width="70" height="70" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Proof">
                            <ItemTemplate>
                                 <img src="../Assests/Clubdoc/<%#Eval("nc_proof") %>" width="70" height="70" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Fields>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                </asp:DetailsView>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
         </div>
</asp:Content>

