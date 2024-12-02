<%@ Page Title="" Language="C#" MasterPageFile="~/Club/ClubMaster.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Club_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 112px;
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
            <td class="auto-style2">Welcome </td>
            <td>
                <asp:Label ID="lblmsg" runat="server" style="font-weight: 700"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <%--<tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">PlayerDetails</asp:LinkButton>
            </td>
        </tr>--%>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

