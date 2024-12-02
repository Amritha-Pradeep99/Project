<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="NewsUpload.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .form-container {
            margin-top: 100px;
            width: 100%;
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        .form-group {
            display: flex;
            margin-bottom: 20px;
            width: 100%;
            max-width: 800px;
            justify-content: space-between;
        }

        .form-group label {
            width: 150px;
            text-align: right;
            margin-right: 10px;
            font-weight: bold;
        }

        .form-group .input-container {
            flex: 1;
        }

        .form-group .input-container input,
        .form-group .input-container textarea {
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
        }

        .form-group .input-container input[type="checkbox"] {
            width: auto;
        }

        .form-actions {
            display: flex;
            justify-content: center;
            margin-top: 20px;
        }

        .form-actions button {
            margin: 0 10px;
            padding: 10px 20px;
        }
        .form-control {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin:0;
        }
         #ContentPlaceHolder1_txtcaption  {
             margin: 0;
        }
          #ContentPlaceHolder1_txtnews  {
             margin: 0;
        }
           #ContentPlaceHolder1_chkshow  {
             margin: 0;
        }
             #ContentPlaceHolder1_btnsave  {
             margin: 0;
        }
              #ContentPlaceHolder1_btncancel  {
             margin: 0;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="form-container">
        <div class="form-group">
            <label for="txtcaption">Caption</label>
            <div class="input-container">
                <asp:TextBox ID="txtcaption" runat="server"   Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcaption" ErrorMessage="Enter EndDate"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label for="txtnews">News</label>
            <div class="input-container">
                <asp:TextBox ID="txtnews" runat="server" Height="120px" Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnews" ErrorMessage="Enter EndDate"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label>&nbsp;</label>
            <div class="input-container">
                <asp:CheckBox ID="chkshow" runat="server" Text="Show in homepage" OnCheckedChanged="chkshow_CheckedChanged" />
               <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="chkshow" ErrorMessage="Click CheckBox To Show in Homepage"></asp:RequiredFieldValidator>--%>
            </div>
        </div>
        <div class="form-actions">
            <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" Width="100px" BackColor="#3399FF" />
            <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" Width="100px" BackColor="#999999" />
        </div>
    </div>
</asp:Content>
