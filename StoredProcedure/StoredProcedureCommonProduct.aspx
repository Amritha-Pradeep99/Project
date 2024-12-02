<%@ Page Title="" Language="C#" MasterPageFile="~/StoredProcedure/StoredProcedureMasterPage.master" AutoEventWireup="true" CodeFile="StoredProcedureCommonProduct.aspx.cs" Inherits="StoredProcedure_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 128px;
        }
        .auto-style3 {
            width: 128px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Category</td>
            <td>
                <asp:DropDownList ID="ddlcategory" runat="server" AutoPostBack="True" Width="200px" OnSelectedIndexChanged="ddlcategory_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Subcategory</td>
            <td>
                <asp:DropDownList ID="ddlsubcategory" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Product Name</td>
            <td>
                <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Product Price</td>
            <td>
                <asp:TextBox ID="txtprice" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Photo</td>
            <td>
                <asp:FileUpload ID="filephoto" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
                <asp:Button ID="btnshow" runat="server" Text="Show" OnClick="btnshow_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">ID</td>
            <td>
                <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:GridView ID="gddetails" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnRowCommand="gddetails_RowCommand">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="product_id" HeaderText="ID" />
                        <asp:BoundField DataField="product_Name" HeaderText="Product" />
                        <asp:BoundField DataField="product_price" HeaderText="Price" />
                        <asp:BoundField DataField="subcategory_name" HeaderText="Subcategory" />
                        <asp:BoundField DataField="ct_name" HeaderText="Category" />
                        <asp:TemplateField HeaderText="Photo">
                            <ItemTemplate>
                               <img src="../Assests/Product/<%#Eval("product_photo") %>" width="50" height="50" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:Button ID="btnedit" runat="server" CommandArgument='<%# Eval("product_id") %>' CommandName="ed" Text="Edit" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:Button ID="btndelete" runat="server" CommandArgument='<%# Eval("product_id") %>' CommandName="del" Text="Delete" />
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
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

