<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="PositiveNegative.aspx.cs" Inherits="Basics_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 146px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Number</td>
            <td>
                <asp:TextBox ID="txtno1" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Choice</td>
            <td>
                <asp:DropDownList ID="ddlchoice" runat="server" Width="200px">
                    <asp:ListItem Value="1">1</asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnchoice" runat="server" OnClick="btnchoice_Click" style="margin-left: 26px" Text="Choice" Width="150px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Result</td>
            <td>
                <asp:Label ID="lblresult" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

