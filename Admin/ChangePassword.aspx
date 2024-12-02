﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       .form-container {
            width: 100%;
            max-width: 400px;
            margin: 120px auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            background-color: #fff;
        }
        .form-group {
            margin-bottom: 15px;
        }
         .form-control {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin:0;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .form-group .buttons {
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
            margin:0;
        }
        .form-group .buttons input {
            width: 48%;
        }
        .form-group .message {
            margin-top: 15px;
            color: red;
        }
         .btn-primary {
            background-color: #007bff;
            color: #fff;
        }

            .btn-primary:hover {
                background-color: #0056b3;
            }

        .btn-secondary {
            background-color: #6c757d;
            color: #fff;
        }

            .btn-secondary:hover {
                background-color: #5a6268;
            }
        .auto-style1 {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="form-container">
        <div class="form-group">
            <label for="txtpwd"><strong class="auto-style1">Current Password</strong></label>
            <asp:TextBox ID="txtpwd" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpwd" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
        </div>
              <div class="form-group">
            <label for="txtNpwd"><strong class="auto-style1">New Password</strong></label>
            <asp:TextBox ID="txtNpwd" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNpwd" ErrorMessage="Enter New Password"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="txtCpwd"><strong class="auto-style1">Confirm Password</strong></label>
            <asp:TextBox ID="txtCpwd" runat="server" class="form-control"></asp:TextBox>
             <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNpwd" ControlToValidate="txtCpwd" ErrorMessage="Password Mismatch"></asp:CompareValidator>
        </div>
        <div class="form-group buttons">
            <asp:Button ID="btnchange" runat="server" OnClick="btnchange_Click" Text="Change" class="btn btn-primary form-control"/>
            <asp:Button ID="btncancel" runat="server" Text="Cancel" class="btn btn-secondary form-control" OnClick="btncancel_Click" />
        </div>
        <div class="form-group message">
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </div>
    </div>
            
        
</asp:Content>
