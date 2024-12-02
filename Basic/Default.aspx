<%@ Page Title="" Language="C#" MasterPageFile="~/Basic/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Basic_Default" %>

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
            <td class="auto-style2">no1 </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">no2</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Result</td>
            <td>
              
                <asp:Label ID="lblresult" runat="server" ></asp:Label>
              
            </td>
        </tr>
    </table>
</asp:Content>

