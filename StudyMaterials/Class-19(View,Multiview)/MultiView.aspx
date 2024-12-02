<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultiView.aspx.cs" Inherits="Class_19_View_Multiview_MultiView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 110px;
        }
        .style3
        {
            width: 99px;
        }
        .style4
        {
            width: 91px;
        }
        .auto-style1 {
            height: 24px;
        }
        .auto-style2 {
            width: 110px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <table class="style1">
                    <tr>
                        <td class="style3">
                            <asp:LinkButton ID="lnkCourse" runat="server" onclick="lnkCourse_Click">CourseDetails</asp:LinkButton>
                        </td>
                        <td class="style4">
                            <asp:LinkButton ID="lnkBook" runat="server" onclick="lnkBook_Click">BookDetails</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="lnkStudent" runat="server" onclick="lnkStudent_Click">StudentDetails</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="CourseDetails" runat="server" >
                        <table class="style1">
                            <tr>
                                <td class="style2">
                                    Course</td>
                                <td>
                                    <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    Fees</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="txtFees" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    Duration</td>
                                <td>
                                    <asp:TextBox ID="txtDuration" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="BookDetails" runat="server">
                        <table class="style1">
                            <tr>
                                <td class="style2">
                                    BookName</td>
                                <td>
                                    <asp:TextBox ID="txtBook" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    Auother</td>
                                <td>
                                    <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    Price</td>
                                <td>
                                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnAdd" runat="server" Text="Add" />
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="StudentsDetails" runat="server">
                        <table class="style1">
                            <tr>
                                <td class="style2">
                                    RegNo</td>
                                <td>
                                    <asp:TextBox ID="txtReg" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    Name</td>
                                <td>
                                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    Branch</td>
                                <td>
                                    <asp:DropDownList ID="ddlBranch" runat="server" Height="16px" Width="128px">
                                        <asp:ListItem>--select--</asp:ListItem>
                                        <asp:ListItem>CS</asp:ListItem>
                                        <asp:ListItem>EC</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnUpdate" runat="server" Text="Update" />
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                </asp:MultiView>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                </td>
            <td class="auto-style1">
                </td>
            <td class="auto-style1">
                </td>
            <td class="auto-style1">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
