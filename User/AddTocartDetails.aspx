<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="AddTocartDetails.aspx.cs" Inherits="User_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        #ContentPlaceHolder1_txtproduct {
            margin: 0;
        }
        #ContentPlaceHolder1_txtprice {
            margin: 0;
        }
        #ContentPlaceHolder1_txtunit{
            margin: 0;
        }
        #ContentPlaceHolder1_txtcartqty {
            margin: 0;
        }
        #ContentPlaceHolder1_txtcarttotal {
            margin: 0;
        }
        #ContentPlaceHolder1_btnsubmit {
            margin: 0;
        }
         #ContentPlaceHolder1_btncancel {
            margin: 0;
        }
        #ContentPlaceHolder1_btnlist {
            margin: 0;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 244px;
        }
        .auto-style5 {
            width: 19px;
        }
        .auto-style6 {
            width: 91px;
        }
        .auto-style8 {
            width: 65px;
        }
        .auto-style9 {
            width: 4px;
        }
        .auto-style10 {
            width: 332px;
        }
        .auto-style11 {
            width: 193px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style3" colspan="3">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style3" colspan="3">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6">ProductName</td>
            <td class="auto-style3" colspan="3">
                <asp:TextBox ID="txtproduct" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style6">
                Price</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtprice" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style9">
                Unit</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtunit" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6">Cart QTY</td>
            <td class="auto-style3" colspan="3">
                <asp:TextBox ID="txtcartqty" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcartqty" ErrorMessage="Enter QTY Needed"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3" colspan="3">
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="100px" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" />
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3" colspan="3">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6">Total</td>
            <td class="auto-style3" colspan="3">
                <asp:TextBox ID="txtcarttotal" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3" colspan="3">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3" colspan="3">
                <asp:Button ID="btnlist" runat="server" BackColor="#3399FF" BorderColor="White" Height="40px" OnClick="btnlist_Click" Text="Place Order" Width="100px" ForeColor="White" />
                <asp:Button ID="btncontinue" runat="server" BackColor="#66FF66" BorderColor="White" ForeColor="White" Height="40px" OnClick="btncontinue_Click" Text="Continue Shopping" />
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

