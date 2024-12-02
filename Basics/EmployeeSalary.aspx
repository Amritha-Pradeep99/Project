<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="EmployeeSalary.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 180px;
        }
        .auto-style3 {
            width: 180px;
            height: 56px;
        }
        .auto-style4 {
            height: 56px;
        }
        .auto-style5 {
            width: 180px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">First Name</td>
            <td>
                <asp:TextBox ID="txtFname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Last Name</td>
            <td>
                <asp:TextBox ID="txtlname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Gender</td>
            <td class="auto-style4">
                <asp:RadioButtonList ID="rblgender" runat="server" RepeatDirection="Horizontal" Width="200px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Martial Status</td>
            <td>
                <asp:RadioButtonList ID="rblmartial" runat="server" RepeatDirection="Horizontal" Width="200px">
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Dept</td>
            <td>
                <asp:DropDownList ID="ddldept" runat="server" Width="200px">
                    <asp:ListItem>CSE</asp:ListItem>
                    <asp:ListItem>CS</asp:ListItem>
                    <asp:ListItem>EEE</asp:ListItem>
                    <asp:ListItem>ECE</asp:ListItem>
                    <asp:ListItem>ME</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Basic Salary</td>
            <td>
                <asp:TextBox ID="txtbs" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="150px" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="150px" OnClick="btncancel_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Name</td>
            <td class="auto-style6">
                <asp:Label ID="lblname" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Gender</td>
            <td>
                <asp:Label ID="lblgender" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Martial</td>
            <td>
                <asp:Label ID="lblmartial" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Department</td>
            <td>
                <asp:Label ID="lbldepartment" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">TA</td>
            <td>
                <asp:Label ID="lblta" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">DA</td>
            <td>
                <asp:Label ID="lblda" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">HRA</td>
            <td>
                <asp:Label ID="lblhra" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">LIC</td>
            <td>
                <asp:Label ID="lbllic" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">PF</td>
            <td class="auto-style6">
                <asp:Label ID="lblpf" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Net</td>
            <td>
                <asp:Label ID="lblnet" runat="server" Width="200px"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

