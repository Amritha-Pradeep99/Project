<%@ Page Title="" Language="C#" MasterPageFile="~/Player/PlayerMaster.master" AutoEventWireup="true" CodeFile="RateNow.aspx.cs" Inherits="Player_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .move {
            margin-top: 60px;
        }
        .form-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            width: 100%;
            max-width: 400px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
         .form-control {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin:0;
        }
        .form-group {
            width: 100%;
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .form-group input, .form-group select, .form-group textarea {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .form-group textarea {
            resize: vertical;
        }
        
         .form-actions {
            display: flex;
            justify-content: space-between;
            align-items: center;
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
        <div class="form-group">
            <label for="drpratevalue">Rate Value</label>
            <asp:DropDownList ID="drpratevalue" runat="server" class="form-control"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Rate " ControlToValidate="drpratevalue" InitialValue="--Select--"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="txtcomment">Rate Comment</label>
            <asp:TextBox ID="txtcomment" runat="server" TextMode="MultiLine" Rows="4" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Comment" ControlToValidate="txtcomment"></asp:RequiredFieldValidator>
        </div>
        <div class="form-actions">
           <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Edit" class="btn btn-primary" />
           <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" class="btn btn-secondary"  />

        </div>
    </div>
    </div>

</asp:Content>
