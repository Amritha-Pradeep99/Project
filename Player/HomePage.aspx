<%@ Page Title="" Language="C#" MasterPageFile="~/Player/PlayerMaster.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Player_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 113px;
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
        <td class="auto-style2">Welcome</td>
        <td>
            <asp:Label ID="lblmsg" runat="server" style="font-weight: 700"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    </table>
</asp:Content>

