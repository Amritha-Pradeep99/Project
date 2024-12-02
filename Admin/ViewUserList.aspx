<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewUserList.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .move {
            margin-top: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="move">
         <table class="w-100">
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>
    <asp:GridView ID="grdDs" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnPageIndexChanging="grdDs_PageIndexChanging" PageSize="5" Width="263px" GridLines="Vertical" >
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField DataField="nu_fname" HeaderText="Fname" />
            <asp:BoundField DataField="nu_lname" HeaderText="Lname" />
            <asp:BoundField DataField="nu_gender" HeaderText="Gender" />
            <asp:BoundField DataField="nu_martial" HeaderText="Martial" />
            <asp:BoundField DataField="nu_qual" HeaderText="Qualification" />
            <asp:BoundField DataField="nu_usern" HeaderText="UserName" />
            <asp:BoundField DataField="nu_email" HeaderText="Email" />
            <asp:BoundField DataField="nu_phone" HeaderText="Phone" />
            <asp:BoundField DataField="nu_address" HeaderText="Address" />
            <asp:BoundField DataField="place_name" HeaderText="PlaceName" />
            <asp:BoundField DataField="district_name" HeaderText="DistrictName" />
            <asp:TemplateField HeaderText="Photo">
                <ItemTemplate>
                    <img src="../Assests/UserDocs/<%#Eval("nu_photo")%>" width="50" height="50" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Proof">
                <ItemTemplate>
                     <img src="../Assests/UserDocs/<%#Eval("nu_proof")%>" width="50" height="50" />
                </ItemTemplate>
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
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
         </table>
         </div>
</asp:Content>

