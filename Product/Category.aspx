<%@ Page Title="" Language="C#" MasterPageFile="~/Product/ProductMaster.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Product_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 135px;
        }
        .auto-style4 {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style4">CategoryName</td>
            <td>
                <asp:TextBox ID="txtcategory" runat="server" Width="200px" OnTextChanged="txtcategory_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="100px" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table>
                            <tr>
                                <th>CategoryName</th>
                                <th>Delete</th>
                                <th>Edit</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                       
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("ct_name") %>'> </asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="btndelete" runat="server" CommandName="del" Text="Delete" CommandArgument='<%#Eval("ct_id") %>' />
                                </td>
                                <td>
                                    <asp:Button ID="btnedit" runat="server" CommandName="ed" Text="Edit" CommandArgument='<%#Eval("ct_id") %>' />
                                </td>
                            </tr>
                        
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
        </tr>
    </table>
</asp:Content>

