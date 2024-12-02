<%@ Page Title="" Language="C#" MasterPageFile="~/Product/ProductMaster.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 119px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 119px;
            height: 23px;
        }
        .auto-style5 {
            width: 270px;
        }
        .auto-style6 {
            height: 23px;
            width: 270px;
        }
        .auto-style7 {
            width: 50px;
        }
        .auto-style8 {
            height: 23px;
            width: 50px;
        }
        .auto-style9 {
            width: 43px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Category</td>
            <td class="auto-style5" colspan="6">
                <asp:DropDownList ID="ddlcategory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlcategory_SelectedIndexChanged" Width="200px">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Subcategory</td>
            <td class="auto-style5" colspan="6">
                <asp:DropDownList ID="ddlsubcategory" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">ProductName</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="txtPname" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style9" colspan="2">
                &nbsp;</td>
            <td class="auto-style5" colspan="2">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">ProductPrice</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtprice" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style2" colspan="2">
                Unit</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="txtunit" runat="server" Width="200px" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Photo</td>
            <td class="auto-style5" colspan="6">
                <asp:FileUpload ID="filephoto" runat="server" />
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" Width="100px" OnClick="btnsubmit_Click" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" OnClick="btncancel_Click" />
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">
                <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1">
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td> <img src="../Assests/Product/<%#Eval("product_photo")%>" width="70" height="70" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("product_Name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("product_price") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("ct_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("subcategory_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                
                                <td class="auto-style3">
                                    <asp:Button ID="btndelete" runat="server" Text="Delete" CommandName="del" CommandArgument='<%#Eval("product_id") %>'/>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Button ID="btnedit" runat="server" Text="Edit" CommandName="ed" CommandArgument='<%#Eval("product_id") %>' />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">
                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                        <table>
                            <tr>
                                
                                <th>ProductName</th>
                                <th>ProductPrice</th>
                                <th>Category</th>
                               <th>Subcategory</th>
                                <th>Photo</th>
                                <th>Delete</th>
                                <th>Edit</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                      <tr>
                          <td>
                              <asp:Label ID="Label5" runat="server" Text='<%#Eval("product_Name") %>' ></asp:Label>
                          </td> 
                          <td>
                              <asp:Label ID="Label6" runat="server" Text='<%#Eval("product_price") %>' ></asp:Label>
                          </td>
                          <td>
                              <asp:Label ID="Label7" runat="server" Text='<%#Eval("ct_name") %>' ></asp:Label>
                          </td>
                          <td>
                              <asp:Label ID="Label8" runat="server" Text='<%#Eval("subcategory_name") %>' ></asp:Label>
                          </td>
                          <td>
                              <img src="../Assests/Product/<%#Eval("product_photo")%>" width="50" height="50" />
                          </td>
                          <td>
                              <asp:Button ID="btndelete" runat="server" Text="Delete" CommandName="del" CommandArgument='<%#Eval("product_id") %>' />
                          </td>
                          <td>
                              <asp:Button ID="btnedit" runat="server" Text="Edit" CommandName="ed" CommandArgument='<%#Eval("product_id") %>' />
                          </td>
                      </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style6" colspan="6">
                </td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
                    <Columns>
                        <asp:BoundField DataField="product_Name" HeaderText="Product" />
                        <asp:BoundField DataField="product_price" HeaderText="Price" />
                        <asp:BoundField DataField="ct_name" HeaderText="Category" />
                        <asp:BoundField DataField="subcategory_name" HeaderText="Subcategory" />
                        <asp:TemplateField HeaderText="Photo">
                            <ItemTemplate>
                                <img src="../Assests/Product/<%#Eval("product_photo") %>" width="50" height="50" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("product_id") %>' CommandName="del" Text="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("product_id") %>' CommandName="ed" Text="Edit" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="6">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

