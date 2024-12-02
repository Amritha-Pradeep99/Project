<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="UserlistByLiterals.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 105px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style2 {
            width: 105px;
        }
        .auto-style3 {
            width: 105px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style7 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">First Name</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtfname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Last Name</td>
            <td>
                <asp:TextBox ID="txtlname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Gender</td>
            <td>
                <asp:RadioButtonList ID="rdbgender" runat="server" RepeatDirection="Horizontal" Width="200px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Martial</td>
            <td>
                <asp:RadioButtonList ID="rdbmartial" runat="server" RepeatDirection="Horizontal" Width="200px">
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">District Name</td>
            <td class="auto-style6">
                <asp:DropDownList ID="ddldist" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="ddldist_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Place Name</td>
            <td class="auto-style6">
                <asp:DropDownList ID="ddlplace" runat="server" Width="200px" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Qualification</td>
            <td class="auto-style6">
                <asp:DropDownList ID="ddlqual" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Username</td>
            <td>
                <asp:TextBox ID="txtusern" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Password</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtpwd" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Email</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtemail" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Phone Number</td>
            <td>
                <asp:TextBox ID="txtpn" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Address</td>
            <td>
                <asp:TextBox ID="txtaddress" runat="server" Height="100px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Photo</td>
            <td class="auto-style4">
                <asp:FileUpload ID="filephoto" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Proof</td>
            <td>
                <asp:FileUpload ID="fileproof" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" Width="90px" />
                
                <asp:Button ID="btnshow" runat="server" OnClick="btnshow_Click" Text="Show" Width="100px" />
                
            </td>
        </tr>
        <tr>
            <td class="auto-style7">ID</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtid" runat="server" Height="22px"></asp:TextBox>
                <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Literal ID="ltrlUserlist" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

