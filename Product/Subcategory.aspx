<%@ Page Title="" Language="C#" MasterPageFile="~/Product/ProductMaster.master" AutoEventWireup="true" CodeFile="Subcategory.aspx.cs" Inherits="Product_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 153px;
        }
        .auto-style3 {
            width: 153px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Category</td>
            <td>
                <asp:DropDownList ID="ddlcategory" runat="server" AutoPostBack="True" Width="200px" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">SubcategoryName</td>
            <td>
                <asp:TextBox ID="txtsubcategory" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="100px" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table>
                            <tr>
                                <th>CategoryName</th>
                                <th>SubcategoryName</th>
                                <th>Delete</th>
                                <th>Edit</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                       <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("ct_name") %>'></asp:Label>
                            </td>
                           <td>
                               <asp:Label ID="Label2" runat="server" Text='<%#Eval("subcategory_name") %>'></asp:Label>
                           </td>
                            <td>
                                <asp:Button ID="btndelete" runat="server" CommandName="del" Text="Delete" CommandArgument='<%#Eval("subcategory_id") %>' />
                            </td>
                           <td>
                               <asp:Button ID="btnedit" runat="server" CommandName="ed" Text="Edit" CommandArgument='<%#Eval("subcategory_id") %>' />
                           </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

