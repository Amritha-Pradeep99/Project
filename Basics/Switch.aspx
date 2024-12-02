<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="Switch.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 123px;
        }
        .auto-style3 {
            width: 123px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Number1</td>
            <td>
                <asp:TextBox ID="txtnumber1" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Number2</td>
            <td>
                <asp:TextBox ID="txtnumber2" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Choice</td>
            <td id="radiosum">
                <asp:DropDownList ID="ddlchoice" runat="server" OnSelectedIndexChanged="ddlchoice_SelectedIndexChanged" Width="225px">
                    <asp:ListItem Value="1">+</asp:ListItem>
                    <asp:ListItem Value="2">-</asp:ListItem>
                    <asp:ListItem Value="3">*</asp:ListItem>
                    <asp:ListItem Value="4">/</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td id="radiosum" class="auto-style4">
                <asp:Button ID="btnchoice" runat="server" OnClick="btnchoice_Click" style="margin-left: 30px" Text="choice" Width="109px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Result</td>
            <td>
                <asp:Label ID="lblresult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

