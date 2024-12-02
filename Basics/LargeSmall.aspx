<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="LargeSmall.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 109px;
        }
        .auto-style3 {
            width: 109px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">Number-1</td>
                        <td>
                            <asp:TextBox ID="txtnumber1" runat="server" OnTextChanged="txtnumber1_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Number-2</td>
                        <td>
                            <asp:TextBox ID="txtnumber2" runat="server" OnTextChanged="txtnumber2_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Number-3</td>
                        <td>
                            <asp:TextBox ID="txtnumber3" runat="server" OnTextChanged="txtnumber3_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:Button ID="btndisplay" runat="server" OnClick="btndisplay_Click" Text="&gt;" Width="200px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Large</td>
                        <td id="lbllarge" class="auto-style4">
                            <asp:Label ID="lbllarge" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Small</td>
                        <td id="lblsmall" class="auto-style4">
                            <asp:Label ID="lblsmall" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

