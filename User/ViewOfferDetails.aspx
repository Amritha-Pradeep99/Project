<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="ViewOfferDetails.aspx.cs" Inherits="User_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 24px;
        }
    .auto-style3 {
        width: 321px;
    }
    .auto-style4 {
        height: 24px;
        width: 321px;
    }
    .auto-style5 {
        width: 115px;
    }
    .auto-style6 {
        height: 24px;
        width: 115px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:BulletedList ID="bloffer" runat="server" DisplayMode="LinkButton" OnClick="bloffer_Click">
                </asp:BulletedList>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" OnRowCommand="GridView1_RowCommand" ForeColor="Black" GridLines="Vertical" >
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="offer_name" HeaderText="OfferName" />
                        <asp:BoundField DataField="offer_fromdate" HeaderText="OfferFromDate" />
                        <asp:BoundField DataField="offer_todate" HeaderText="OfferToDate" />
                        <asp:BoundField DataField="ct_name" HeaderText="Category" />
                        <asp:BoundField DataField="subcategory_name" HeaderText="Subcategory" />
                        <asp:BoundField DataField="product_name" HeaderText="Product" />
                        <asp:BoundField DataField="product_price" HeaderText="ProductPrice" />
                        <asp:BoundField DataField="offer_price" HeaderText="OfferPrice" />
                        <asp:TemplateField HeaderText="Photo">
                            <ItemTemplate>
                                <img src="../Assests/Product/<%#Eval("product_photo")%>" width="50" height="50" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AddToCart">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("product_id") %>' CommandName="ac">AddToCart</asp:LinkButton>
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
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                        <table>
                         <tr>
                            <th>OfferName</th>
                            <th>OfferFromDate</th>
                            <th>OfferToDate</th>
                             <th>Category</th>
                             <th>Subcategory</th>
                            <th>Product</th>
                             <th>productPrice</th>
                            <th>OfferPrice</th>
                             <th>Photo</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Eval("offer_name") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("offer_fromdate") %>'></asp:Label>
                            </td>
                            <td>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Eval("offer_todate") %>'></asp:Label>
                            </td>
                            <td>
                                 <asp:Label ID="Label4" runat="server" Text='<%# Eval("ct_name") %>'></asp:Label>
                            </td>
                            <td>
                                 <asp:Label ID="Label5" runat="server" Text='<%# Eval("subcategory_name") %>'></asp:Label>
                            </td>
                            <td>
                                 <asp:Label ID="Label6" runat="server" Text='<%# Eval("product_name") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label17" runat="server" Text='<%# Eval("product_price") %>'></asp:Label>
                            </td>
                            
                            <td>
                                <asp:Label ID="Label8" runat="server" Text='<%# Eval("offer_price") %>'></asp:Label>
                            </td>
                            <td>
                                <img src="../Assests/Product/<%#Eval("product_photo")%>" width="50" height="50" />
                            </td>
                        </tr>
                        
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Both" RepeatDirection="Horizontal">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td><img src="../Assests/Product/<%#Eval("product_photo")%>" width="50" height="50" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label18" runat="server" Text='<%# Eval("offer_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text='<%# Eval("offer_fromdate") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text='<%# Eval("offer_todate") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                 <asp:Label ID="Label11" runat="server" Text='<%# Eval("ct_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                 <asp:Label ID="Label12" runat="server" Text='<%# Eval("subcategory_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label13" runat="server" Text='<%# Eval("product_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                <asp:Label ID="Label14" runat="server" Text='<%# Eval("product_price") %>'></asp:Label>
                            </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label15" runat="server" Text='<%# Eval("offer_price") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

