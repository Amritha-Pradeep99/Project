<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 154px;
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
            <td class="auto-style2">CourseName</td>
            <td>
                <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">CourseDuration</td>
            <td>
                <asp:TextBox ID="txtduration" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">CourseFees</td>
            <td>
                <asp:TextBox ID="txtfees" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" Width="100px" OnClick="btnsubmit_Click" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel"  Width="100px" OnClick="btncancel_Click"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand"  >
                   <HeaderTemplate>
                       <table>

                           <tr>
                               <th>CourseName</th>
                               <th>CourseDuration</th>
                                <th>CourseFees</th>
                               <th>Delete</th>
                               <th>Edit</th>
                           </tr>
                          
                   </HeaderTemplate>
                    <ItemTemplate>
                         <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("course_name") %>'> </asp:Label>
                                </td>
                             <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("course_duration") %>'></asp:Label>
                                </td>
                              <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("course_fees") %>'></asp:Label>
                              </td>
                             <td>
                                 <asp:Button ID="btndelete" runat="server" CommandName="del" Text="Delete" CommandArgument='<%#Eval("course_id") %>' />
                             </td>
                             <td>
                             <asp:Button ID="btnedit" runat="server" CommandName="ed" Text="Edit" CommandArgument='<%#Eval("course_id") %>' />
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

