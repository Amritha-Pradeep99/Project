<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListView-1.aspx.cs" Inherits="Class_23_ListView_ListView_1" %>

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
        }
        .style3
        {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3" colspan="2">
                    <strong>SqlDataSource --- To connect with database</strong></td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    <strong>ListViewTask---Configure ListView ---Select Layout---Enable Paging</strong></td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    <strong>DataPager(for Paging) --- select property of DataPager --- set pagesize</strong></td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:ListView ID="ListView1" runat="server" DataKeyNames="course_id" 
                        DataSourceID="SqlDataSource1">
                        <AlternatingItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Label ID="course_idLabel" runat="server" Text='<%# Eval("course_id") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_durationLabel" runat="server" Text='<%# Eval("course_duration") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_feesLabel" runat="server" Text='<%# Eval("course_fees") %>' />
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <EditItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                                        Text="Update" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                                        Text="Cancel" />
                                </td>
                                <td>
                                    <asp:Label ID="course_idLabel1" runat="server" Text='<%# Eval("course_id") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="course_nameTextBox" runat="server" Text='<%# Bind("course_name") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="course_durationTextBox" runat="server" 
                                        Text='<%# Bind("course_duration") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="course_feesTextBox" runat="server" Text='<%# Bind("course_fees") %>' />
                                </td>
                            </tr>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" 
                                style="">
                                <tr>
                                    <td>
                                        No data was returned.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <InsertItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                                        Text="Insert" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                                        Text="Clear" />
                                </td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="course_nameTextBox" runat="server" Text='<%# Bind("course_name") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="course_durationTextBox" runat="server" 
                                        Text='<%# Bind("course_duration") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="course_feesTextBox" runat="server" Text='<%# Bind("course_fees") %>' />
                                </td>
                            </tr>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Label ID="course_idLabel" runat="server" Text='<%# Eval("course_id") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_durationLabel" runat="server" Text='<%# Eval("course_duration") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_feesLabel" runat="server" Text='<%# Eval("course_fees") %>' />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table ID="itemPlaceholderContainer" runat="server" border="0" 
                                            style="">
                                            <tr runat="server" style="">
                                                <th runat="server">
                                                    course_id</th>
                                                <th runat="server">
                                                    course_name</th>
                                                <th runat="server">
                                                    course_duration</th>
                                                <th runat="server">
                                                    course_fees</th>
                                            </tr>
                                            <tr ID="itemPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" 
                                        style="">
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <SelectedItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Label ID="course_idLabel" runat="server" Text='<%# Eval("course_id") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_durationLabel" runat="server" Text='<%# Eval("course_duration") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="course_feesLabel" runat="server" Text='<%# Eval("course_fees") %>' />
                                </td>
                            </tr>
                        </SelectedItemTemplate>
                    </asp:ListView>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:db_projectConnectionString %>" 
                        SelectCommand="SELECT * FROM [tbl_course]"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
