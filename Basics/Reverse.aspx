<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="Reverse.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 105px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Number</td>
            <td id="txtnumber">
                <asp:TextBox ID="txtnumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnreverse" runat="server" OnClick="btnreverse_Click" Text="Button" Width="200px" />
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

