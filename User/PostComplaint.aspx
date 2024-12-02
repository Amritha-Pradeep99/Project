<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="PostComplaint.aspx.cs" Inherits="User_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 132px;
        }
        .auto-style3 {
            width: 132px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
        .auto-style7 {
            width: 353px;
        }
        .auto-style8 {
            height: 25px;
            width: 353px;
        }
        .auto-style9 {
            width: 196px;
        }
        .auto-style10 {
            height: 25px;
            width: 196px;
        }
        .auto-style11 {
            width: 104px;
        }
        .auto-style12 {
            height: 25px;
            width: 104px;
        }
        .move {
            margin-top: 70px;
        }
        .auto-style13 {
            width: 138px;
        }
        .auto-style14 {
            height: 25px;
            width: 138px;
        }
         #ContentPlaceHolder1_txtct {
             margin: 0;
        }
          #ContentPlaceHolder1_txtcom {
             margin: 0;
        }
           #ContentPlaceHolder1_btnsubmit {
             margin: 0;
        }
            #ContentPlaceHolder1_btncancel {
             margin: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="move" >
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
            <td class="auto-style11">
                Complaint Title</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtct" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtct" ErrorMessage="Enter Complaint Title"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style12">
                Complaint 
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="txtcom" runat="server" Height="100px" Width="200px" ></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcom" ErrorMessage="Enter Complaint Content"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="100px" BackColor="#009999" ForeColor="White" BorderColor="White" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" OnClick="btncancel_Click" BackColor="Gray" ForeColor="White" BorderColor="White" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>
</asp:Content>

