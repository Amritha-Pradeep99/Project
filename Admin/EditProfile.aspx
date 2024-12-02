﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="EditProfile.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        
        .move {
            display: flex;
            justify-content: center;
             //margin-top:90px;
        }

        .form-container {
           
            max-width: 600px;
            min-width:500px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 8px;
            background-color: #f9f9f9;
             margin-top:120px;
        }

        .form-group-edit{
            margin-bottom: 15px;
        }

            .form-group-edit label {
                display: block;
                margin-bottom: 5px;
                font-weight: bold;
            }

        .form-control {
              padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin:0;
        }

        .form-actions {
            display: flex;
            justify-content: space-between;
        }

        .btn {
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
            margin:0;
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
   
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="move">
        <div class="form-container">
            <div class="form-group-edit">
                <label for="txtname">Name</label>
                <asp:TextBox ID="txtname" runat="server" class="form-control" Width="396px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="Enter Correct EmailID"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group-edit">
                <label for="txtcontact">Contact</label>
               <asp:TextBox ID="txtcontact" runat="server" Width="400px" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcontact" ErrorMessage="Enter Correct EmailID"></asp:RequiredFieldValidator>
                <%--<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator>--%>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Update" Width="100px" class="btn btn-primary"/>
                 <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" Width="100px" class="btn btn-secondary"/>

            </div>
        </div>

    </div>
</asp:Content>

