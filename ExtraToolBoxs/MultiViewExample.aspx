<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="MultiViewExample.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 171px;
        }
        .auto-style4 {
            width: 371px;
        }
        .auto-style7 {
            width: 142px;
        }
        .auto-style10 {
            width: 139px;
        }
        .auto-style11 {
            width: 138px;
        }
        .auto-style12 {
            width: 142px;
            height: 23px;
        }
        .auto-style13 {
            height: 23px;
        }
        .auto-style14 {
            width: 146px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style14">
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">CourseDetails</asp:LinkButton>
            </td>
            <td class="auto-style3">
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">BookDetails</asp:LinkButton>
            </td>
            <td class="auto-style4">
                <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">StudentsDetails</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:MultiView ID="MultiView1" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:View ID="CourseDetails" runat="server">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style7">Course</td>
                                            <td>
                                                <asp:TextBox ID="txtcourse" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">Fees</td>
                                            <td>
                                                <asp:TextBox ID="txtfees" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style12">Duration</td>
                                            <td class="auto-style13">
                                                <asp:TextBox ID="txtduration" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnsave" runat="server" Text="Save" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:View>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:View ID="BookDetails" runat="server">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style10">BookName</td>
                                            <td>
                                                <asp:TextBox ID="txtbookname" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style10">Author</td>
                                            <td>
                                                <asp:TextBox ID="txtauthor" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style10">Price</td>
                                            <td>
                                                <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style10">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnadd" runat="server" Text="Add" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:View>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:View ID="StudentsDetails" runat="server">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style11">RegNo</td>
                                            <td>
                                                <asp:TextBox ID="txtregno" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style11">Name</td>
                                            <td>
                                                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style11">Branch</td>
                                            <td>
                                                <asp:DropDownList ID="ddlbranch" runat="server" Width="124px">
                                                    <asp:ListItem>--select--</asp:ListItem>
                                                    <asp:ListItem>CS</asp:ListItem>
                                                    <asp:ListItem>EC</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style11">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnupdate" runat="server" Text="update" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:View>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:MultiView>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

