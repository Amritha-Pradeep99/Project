<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="Perfect.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 110px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Number</td>
            <td>
                <asp:TextBox ID="txtnumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnperfect" runat="server" OnClick="btnperfect_Click" Text="Button" Width="200px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Perfect</td>
            <td>
                <asp:Label ID="lblperfect" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Not Perfect</td>
            <td>
                <asp:Label ID="lblnperfect" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

