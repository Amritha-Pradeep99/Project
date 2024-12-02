<%@ Page Title="" Language="C#" MasterPageFile="~/Sales/SalesMasterPage.master" AutoEventWireup="true" CodeFile="PurchaseItem.aspx.cs" Inherits="Sales_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 73px;
        }
        .auto-style3 {
            width: 225px;
        }
        .auto-style4 {
            width: 125px;
        }
        .auto-style5 {
            width: 92px;
        }
        .auto-style6 {
            width: 73px;
            height: 26px;
        }
        .auto-style7 {
            width: 225px;
            height: 26px;
        }
        .auto-style8 {
            width: 125px;
            height: 26px;
        }
        .auto-style9 {
            width: 92px;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
        .auto-style11 {
            width: 73px;
            height: 23px;
        }
        .auto-style13 {
            height: 23px;
        }
        .auto-style14 {
            width: 125px;
            height: 23px;
        }
        .auto-style15 {
            width: 92px;
            height: 23px;
        }
        .auto-style16 {
            width: 205px;
            height: 23px;
        }
        .auto-style17 {
            width: 205px;
        }
        .auto-style18 {
            width: 339px;
            height: 23px;
        }
        .auto-style19 {
            width: 339px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"><strong>Item</strong></td>
            <td class="auto-style7">
                <asp:DropDownList ID="ddlitem" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlitem_SelectedIndexChanged" Width="170px">
                </asp:DropDownList>
            </td>
            <td class="auto-style6"><strong>Price</strong></td>
            <td class="auto-style8">
                <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style9"><strong>QTY</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="txtqty" runat="server" Width="200px" OnTextChanged="txtqty_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="btnadd" runat="server" Height="39px" OnClick="btnadd_Click" Text="Add" Width="130px" />
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" style="margin-left: 286px" Width="479px" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="SNo">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="product_Name" HeaderText="Item" />
                <asp:TemplateField HeaderText="Photo">
                    <ItemTemplate>
                       <img src="../Assests/Product/<%#Eval("product_photo") %>" width="50" height="50" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="product_price" HeaderText="Price" />
                <asp:BoundField DataField="cart_qty" HeaderText="Qty" />
                <asp:BoundField DataField="cart_total" HeaderText="Total" />
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:Button ID="btndelete" runat="server" CommandArgument='<%# Eval("cart_id") %>' CommandName="del" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style18"></td>
            <td class="auto-style16"></td>
            <td class="auto-style14"></td>
            <td class="auto-style15"></td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style17"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GrandTotal</strong></td>
            <td class="auto-style4">
                <asp:Label ID="lbltotal" runat="server"></asp:Label>
                /-</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="btncheckout" runat="server" OnClick="btncheckout_Click" Text="Checkout" />
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

