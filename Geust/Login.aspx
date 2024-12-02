<%@ Page Title="" Language="C#" MasterPageFile="~/Geust/GeustMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Geust_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .container {
            display: flex;
            justify-content: center;
            align-items: center;
           margin-top:100PX;
            
        }

        .login-form {
            width: 350px;
            background-color: lightgreen;
            border-radius: 20px;
            padding: 20px;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        .form-control {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin:0;
        }

        .row {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 10px;
        }

        .button {
            flex: 1;
            margin: 0 5px;
            padding: 10px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            text-align: center;
        }

        .button.login {
            background-color: #66FF66;
            font-weight: bold;
        }

        .button.cancel {
            background-color: #FF6666;
            font-weight: bold;
        }

        .message {
            width: 100%;
            margin-top: 10px;
            text-align: center;
        }
       
    </style>
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="login-form">
            <div class="form-group">
                <label for="TextBox1">Email:</label>
                <asp:TextBox ID="txtemail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Enter Correct EmailID"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="txtpassword">Password:</label>
                <asp:TextBox ID="txtpassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Enter Correct Password"></asp:RequiredFieldValidator>
            </div>
            <div class="row">
                <asp:Button ID="btnLogin" runat="server" CssClass="button login" Text="Login" OnClick="btnlogin_Click" />
                <asp:Button ID="btncancel" runat="server" CssClass="button cancel" Text="Cancel" OnClick="btncancel_Click" />
            </div>
            <div class="message">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
