<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="sumdiff.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Number1</td>
            <td>
                <asp:TextBox ID="txtnumber1" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Number2</td>
            <td>
                <asp:TextBox ID="txtnumber2" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Number3</td>
            <td>
                <asp:TextBox ID="txtnumber3" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnSum" runat="server" OnClick="btnSum_Click" Text="Sum" Width="200px" />
                <asp:Button ID="txtdifference" runat="server" OnClick="txtdifference_Click" Text="Difference" Width="200px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Sum</td>
            <td>
                <asp:Label ID="lblsum" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Difference</td>
            <td>
                <asp:Label ID="lbldiff" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

