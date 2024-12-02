<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="Semester.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 116px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Semester</td>
            <td>
                <asp:TextBox ID="txtsemester" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" Width="100px" OnClick="btnsubmit_Click"/>
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" OnClick="btncancel_Click"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table>
                            <tr>
                                <th>SemesterName</th>
                                <th>Delete</th>
                                <th>Edit</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                       
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("sem_name") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="btndelete" runat="server" CommandName="del" Text="Delete"  CommandArgument='<%#Eval("sem_id") %>' />
                                </td>
                                <td>
                                    <asp:Button ID="btnedit" runat="server" CommandName="ed" Text="Edit"  CommandArgument='<%#Eval("sem_id") %>' />
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

