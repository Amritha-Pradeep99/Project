<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="PostFeedback.aspx.cs" Inherits="User_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 118px;
        }
        .auto-style3 {
            width: 138px;
        }
        .move {
            margin-top: 80px;
        }
        .auto-style5 {
            width: 177px;
        }
        .auto-style6 {
            width: 102px;
        }
        #ContentPlaceHolder1_txtfeedback {
             margin: 0;
        }
        #ContentPlaceHolder1_btnsubmit {
             margin: 0;
        }
        #ContentPlaceHolder1_btncancel {
             margin: 0;
        }
        .auto-style7 {
            width: 246px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="move" >
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">
                FeedBack</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtfeedback" runat="server" Height="60px" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfeedback" ErrorMessage="Enter FeedBack"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="100px" BackColor="#009999" ForeColor="White" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" BackColor="#33CCCC" ForeColor="White" OnClick="btncancel_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>
</asp:Content>

