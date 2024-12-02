 <%@ Page Title="" Language="C#" MasterPageFile="~/Geust/GeustMaster.master" AutoEventWireup="true" CodeFile="NewUser.aspx.cs" Inherits="Geust_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style6 {
            height: 26px;
        }
        .center-container {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh; /* Ensure the container takes up the full height of the viewport */
        }
        .center-content {
            width: auto; /* Adjust the width as needed */
            max-width: 480px; /* Set a maximum width */
            background-color:lightsalmon;
          margin-top:30px;
          /*border-radius:20px;*/
        }
       
        
        .column1 {
            /*width:100px;
            height:40px;*/
            display:flex;
            /*justify-content:center;*/
            margin:5px;
            text-align:left;
            color:white;
            font-size:large;
            font:bold;
        }
        .column2 {
            display: flex;
            margin: 5px;
            border-radius:10px;
            border-color:white;
            /*text-align:right;
            justify-content: center;*/
            
        }
        .auto-style7 {
            height: 56px;
        }
        .auto-style8 {
            width: auto;
            height: 56px;
            display: flex; /*justify-content:center;*/;
            margin: 5px;
           align-content:center;
            color: white;
            font-size: large;
        }
        .auto-style11 {
            height: 40px;
            display: flex; /*justify-content:center;*/;
            margin: 5px;
            text-align: left;
            color: white;
            font-size: large;
        }
        #ContentPlaceHolder1_rdbgender_0  {
             margin: 0;
        }
        #ContentPlaceHolder1_rdbgender_1 {
            margin: 0;
        }
         #ContentPlaceHolder1_rdbmartial_0 {
             margin: 0;
        }
         #ContentPlaceHolder1_rdbmartial_1 {
             margin: 0;
        }
         #ContentPlaceHolder1_rdbqual_0 {
            margin: 0;
        }
         #ContentPlaceHolder1_rdbqual_1 {
            margin: 0;
        }
          #ContentPlaceHolder1_txtpn {
            margin: 0;
        }
         .form-control {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin:0;
             display: flex;
            justify-content: flex-end;
        }
        .form-actions {
            display: flex;
            justify-content: center;
        }
        
         .btn {
           padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
            margin-top:4px;
             
        }
         .btn .buttons input {
            width: 48%;
        }
        .btn-primary {
            background-color:#FFA07A;
            color:white;
        }

            .btn-primary:hover {
                background-color: #FFA07A;
            }

        .btn-secondary {
            background-color: #FFA07A;
            color: white;
        }

            .btn-secondary:hover {
                background-color: #FFA07A;
            }
            
           
    .auto-style12 {
        width: 691px;
    }
            
           
        .auto-style13 {
            width: 177px;
        }
        .auto-style14 {
            height: 26px;
            width: 6px;
        }
        .auto-style15 {
            height: 56px;
            width: 6px;
        }
        .auto-style16 {
            width: 6px;
        }
        .auto-style17 {
            height: 23px;
            width: 6px;
        }
          
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="center-container">
        <div class="center-content">
             <div class="center-content">
            <table class="row">
                <tr>
                    <td class="auto-style11" colspan="2">First Name</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtfname" runat="server" class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ErrorMessage="Enter FirstName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="2">Last Name</td>
                    <td class="auto-style15">
                        <asp:TextBox ID="txtlname" runat="server"  class="column2"  Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlname" ErrorMessage="Enter LastName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="column1" colspan="2">Gender</td>
                    <td class="auto-style16" >
                        <asp:RadioButtonList ID="rdbgender" runat="server"   class="column2" RepeatDirection="Horizontal"  Font-Bold="True" Font-Size="Medium" ForeColor="White"  style="margin: 0" >
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td >
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="rdbgender" ErrorMessage="Select Gender"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Marital Status</td>
                    <td class="auto-style16">
                        <asp:RadioButtonList ID="rdbmartial" runat="server" class="column2" RepeatDirection="Horizontal" Width="200px" Font-Bold="True" Font-Size="Medium" ForeColor="White">
                            <asp:ListItem>Single</asp:ListItem>
                            <asp:ListItem>Married</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="rdbmartial" ErrorMessage="Select MartialStatus"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">District Name</td>
                    <td class="auto-style14">
                        <asp:DropDownList ID="ddldist" runat="server" Width="200px"  class="column2" AutoPostBack="True" OnSelectedIndexChanged="ddldist_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddldist" ErrorMessage="Select District" InitialValue="--select--"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Place Name</td>
                    <td class="auto-style14">
                        <asp:DropDownList ID="ddlplace" runat="server"  class="column2" Width="200px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlplace" ErrorMessage="Select Place" InitialValue="--select--"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Qualification</td>
                    <td class="auto-style14">
                        <asp:RadioButtonList ID="rdbqual" runat="server"  class="column2" RepeatDirection="Horizontal" Width="200px" Font-Bold="True" ForeColor="White" Font-Size="Medium">
                            <asp:ListItem>BCA</asp:ListItem>
                            <asp:ListItem>MCA</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="rdbqual" ErrorMessage="Select Qualification"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Email</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtemail" runat="server" class="column2" Width="200px" AutoPostBack="True" OnTextChanged="txtemail_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtemail" ErrorMessage="Enter correct EmailID"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">&nbsp;</td>
                    <td class="auto-style14">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Username</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="txtusern" runat="server"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtusern" ErrorMessage="Enter UserName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Password</td>
                    <td class="auto-style17">
                        <asp:TextBox ID="txtpwd" runat="server"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtpwd" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Retype </td>
                    <td class="auto-style17">
                        <asp:TextBox ID="txtrpwd" runat="server"  class="column2" Width="200px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtrpwd" ErrorMessage="Password Mismatch"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Phone Number</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="txtpn" runat="server"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtpn" ErrorMessage="Enter PhoneNumber"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Address</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="txtaddress" runat="server"  class="column2" Height="100px" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtaddress" ErrorMessage="Enter Address"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Photo</td>
                    <td class="auto-style17">
                        <asp:FileUpload ID="fileImage"  class="column2" runat="server" Width="225px" />
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="fileImage" ErrorMessage="Upload Photo"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Proof</td>
                    <td class="auto-style16">
                        <asp:FileUpload ID="fileproof"  class="column2"  runat="server" Width="225px" />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="fileproof" ErrorMessage="Upload Proof"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                
                <tr>
                    <td class="auto-style12" >
                        <div class="form-actions">
                        <asp:Button ID="btnsave"    runat="server" OnClick="btnsave_Click" Text="Save" Width="201px" BackColor="#FFA07A" BorderColor="White" BorderStyle="Outset" Font-Bold="True" ForeColor="White" BorderWidth="6px" class="btn btn-primary" />
                       
                            </div>
                    </td>
                    <td class="auto-style13" >
                        <asp:Button ID="btncancel" runat="server" BackColor="#FFA07A" BorderColor="White" BorderStyle="Outset" BorderWidth="6px" class="btn btn-secondary" Font-Bold="True" ForeColor="White" OnClick="btncancel_Click" Text="Cancel" Width="194px"  />
                    </td>
                </tr>
                
                
               
                <tr>
                    <td class="auto-style12" >
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style13" >
                        &nbsp;</td>
                </tr>
                
                
               
                </table>
        </div>
    </div>
</div>
</asp:Content>