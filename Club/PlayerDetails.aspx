<%@ Page Title="" Language="C#" MasterPageFile="~/Club/ClubMaster.master" AutoEventWireup="true" CodeFile="PlayerDetails.aspx.cs" Inherits="Club_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 581px;
        }
        .auto-style4 {
            width: 1490px;
        }
        .auto-style5 {
        width: 873px;
    }
        .auto-style8 {
        width: 176px;
    }
        .auto-style9 {
            width: 44px;
        }
        .auto-style11 {
            width: 956px;
        }
         .move {
            margin-top: 70px;
        }
    .auto-style12 {
        width: 62px;
    }
    #ContentPlaceHolder1_txtname {
             margin: 0;
        }
    #ContentPlaceHolder1_txtdob {
             margin: 0;
        }
    #ContentPlaceHolder1_txtemail {
             margin: 0;
             padding:0;
        }
     #ContentPlaceHolder1_txtaddress {
             margin: 0;
        }
    #ContentPlaceHolder1_txtcontact {
             margin: 0;
        }
    #ContentPlaceHolder1_txtpwd {
             margin: 0;
        }
    #ContentPlaceHolder1_txtrpwd {
             margin: 0;
        }
    #ContentPlaceHolder1_filephoto {
             margin: 0;
        }
    #ContentPlaceHolder1_fileproof{
             margin: 0;
        }
    #ContentPlaceHolder1_btnsubmit {
             margin: 0;
        }
    #ContentPlaceHolder1_btncancel {
             margin: 0;
        }
    #ContentPlaceHolder1_btnshow {
             margin: 0;
        }
        .auto-style14 {
            width: 873px;
            height: 129px;
        }
        .auto-style15 {
            width: 176px;
            height: 129px;
        }
        .auto-style17 {
            height: 40px;
            margin:0;
        }
        .auto-style18 {
            width: 182px;
        }
        .auto-style19 {
            width: 182px;
            height: 40px;
            /*margin-bottom:120px;*/
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">&nbsp;&nbsp;
    <div class="move">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style4" colspan="2">
                &nbsp;</td>
            <td colspan="5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">Name</td>
            <td colspan="5">
                <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtname" ErrorMessage="Enter Name"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">Email</td>
            <td colspan="5">
                <asp:TextBox ID="txtemail" runat="server" TextMode="Email" Width="200px" AutoPostBack="True" OnTextChanged="txtemail_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtemail" ErrorMessage="Enter Correct Email"></asp:RequiredFieldValidator>
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">DOB</td>
            <td colspan="5">
                <asp:TextBox ID="txtdob" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtdob" ErrorMessage="Enter correct dob"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">Address</td>
            <td colspan="5">
                <asp:TextBox ID="txtaddress" runat="server" Height="70px" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Address" ControlToValidate="txtaddress"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">Contact</td>
            <td colspan="5">
                <asp:TextBox ID="txtcontact" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Contact Number" ControlToValidate="txtcontact"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">Password</td>
            <td colspan="5">
                <asp:TextBox ID="txtpwd" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Password" ControlToValidate="txtpwd"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">Retype Password</td>
            <td colspan="5">
                <asp:TextBox ID="txtrpwd" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtrpwd" ErrorMessage="Password Mismatch"></asp:CompareValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">Photo</td>
            <td colspan="5">
                <asp:FileUpload ID="filephoto" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="filephoto" ErrorMessage="Upload Photo"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">Proof</td>
            <td colspan="5">
                <asp:FileUpload ID="fileproof" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="fileproof" ErrorMessage="Upload Proof"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td colspan="5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td colspan="5">
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="100px" BackColor="#3399FF" ForeColor="White" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" OnClick="btncancel_Click" BackColor="#009999" ForeColor="White" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td colspan="5">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
    <p>
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>
</asp:Content>

