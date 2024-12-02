<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="Prime.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 114px;
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
                <asp:Button ID="btnprime" runat="server" OnClick="btnprime_Click" Text="Button" Width="200px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Prime</td>
            <td>
                <asp:Label ID="lblprime" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Not Prime</td>
            <td>
                <asp:Label ID="lblnprime" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

