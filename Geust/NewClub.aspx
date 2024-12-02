<%@ Page Title="" Language="C#" MasterPageFile="~/Geust/GeustMaster.master" AutoEventWireup="true" CodeFile="NewClub.aspx.cs" Inherits="Geust_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            margin-right: 44px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style6 {
            padding: 0;
        margin: 0;
        }
        .center-container {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh; /* Ensure the container takes up the full height of the viewport */
            width:auto;
        }
        .center-content {
             
             width: auto; /* Adjust the width as needed */
            max-width: 400px; /* Set a maximum width */
            /*min-width:500px;*/
            
            background-color:darksalmon;
            /*border-radius:20px;*/
            margin-top:40px;
       }
        .row{
	        display:flex;
        }

        .column1{
	        width:150px;
	        height:40px;
	        display:flex;
	       margin:5px;
          color:black;
           color:white;
            font-size:large;
            font:bold;
}
        .column2{
	        width:100px;
	        height:40px;
	        display:flex;
            /*text-align:center;
            align-items:center;*/
	        margin:5px;
             color:black;
             border-radius:10px;
             border-color:white;
             
            }

       

       
        .auto-style7 {
            width: 153px;
            height: 40px;
            display: flex;
            margin: 5px;
            color: black;
            color: white;
            font-size: large;
        }

       

       
        .auto-style9 {
            padding: 0;
        margin: 0;
        }

       
         .button-container {
            display: flex;
            justify-content: center;
            margin-top: 20px; /* Adjust as needed */
            align-items:center;
        }
       
        .button-style {
            display:flex;
            justify-content: space-between;
             margin: 0;
             align-items:center;
    }
      
        #ContentPlaceHolder1_txtcontact {
            margin: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="center-container">
        <div class="center-content">
            <div class="row">
                
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">Name</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server" Width="200px" class="column2" Height="40px" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name" ControlToValidate="txtname"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Email</td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server" class="column2" Width="200px" Height="40px" AutoPostBack="True" OnTextChanged="txtemail_TextChanged"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter correct emilID" ControlToValidate="txtemail"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7" >Contact</td>
                    <td>
                        <asp:TextBox ID="txtcontact" runat="server"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter correct number" ControlToValidate="txtcontact"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">UserName</td>
                    <td>
                        <asp:TextBox ID="txtusername" runat="server"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter UserName" ControlToValidate="txtusername"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Password</td>
                    <td>
                        <asp:TextBox ID="txtpwd" runat="server"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Password" ControlToValidate="txtpwd"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Retype Passwor</td>
                    <td>
                        <asp:TextBox ID="txtrpwd" runat="server"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Mismatch" ControlToCompare="txtpwd" ControlToValidate="txtrpwd"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Address</td>
                    <td>
                        <asp:TextBox ID="txtaddress" runat="server" Height="100px"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter address" ControlToValidate="txtaddress"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Date of Start</td>
                    <td>
                        <asp:TextBox ID="txtdate" runat="server" TextMode="Date"  class="column2" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter joining date" ControlToValidate="txtdate"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">District</td>
                    <td>
                        <asp:DropDownList ID="ddldist" runat="server"  class="column2" OnSelectedIndexChanged="ddldist_SelectedIndexChanged" Width="200px" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Select District" ControlToValidate="ddldist" InitialValue="--select--"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Place</td>
                    <td>
                        <asp:DropDownList ID="ddlplace" runat="server"  class="column2" Width="200px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Select Place" ControlToValidate="ddlplace" InitialValue="--select--"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Photo</td>
                    <td class="auto-style4">
                        <asp:FileUpload ID="filephoto" class="column2" runat="server" />
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Upload Photo" ControlToValidate="filephoto"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Proof</td>
                    <td>
                        <asp:FileUpload ID="fileproof"  class="column2" runat="server" />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Upload Proof" ControlToValidate="fileproof"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                </table>
                <table class="auto-style1">
                <tr>
                    
                    <td class="auto-style9">
                      
                        <asp:Button ID="btnsubmit" runat="server"  OnClick="btnsubmit_Click"   Text="Submit" Width="175px" BackColor="#E9967A" BorderColor="White" class="button-container" Font-Bold="True" ForeColor="White" BorderStyle="Outset" BorderWidth="6px" Height="50px"/>
                        </td>
                    
                    <td class="auto-style6">
                        <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click"  Text="Cancel" Width="179px" BackColor="#E9967A" BorderColor="White"  class="button-container" Font-Bold="True" ForeColor="#FFFFCC" BorderStyle="Outset" BorderWidth="6px" Height="50px" />
                    </td>
                </tr>
                <tr>
                    
                    <td class="auto-style9">
                      
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        </td>
                    
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
            </table>
               </div>
       
  </div>
   </div>
</asp:Content>