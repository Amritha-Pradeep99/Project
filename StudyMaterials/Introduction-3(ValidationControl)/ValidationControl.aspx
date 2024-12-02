<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationControl.aspx.cs" Inherits="Introduction_ValidationControl_ValidationControl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 80px;
        }
        .style3
        {
            width: 164px;
        }
        .style4
        {
            width: 164px;
            color: #CC0000;
        }
        .style5
        {
            width: 164px;
            color: #FF0000;
        }
        .auto-style1 {
            width: 80px;
            height: 31px;
        }
        .auto-style2 {
            width: 164px;
            height: 31px;
        }
        .auto-style3 {
            height: 31px;
        }
        .auto-style4 {
            width: 80px;
            height: 26px;
        }
        .auto-style5 {
            width: 164px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 80px;
            height: 23px;
        }
        .auto-style8 {
            width: 164px;
            color: #FF0000;
            height: 23px;
        }
        .auto-style9 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    FirstName</td>
                <td class="style3">
                    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtfname" ErrorMessage="Enter FirstName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    LastName</td>
                <td class="style3">
                    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtlname" ErrorMessage="Enter LastName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Gender</td>
                <td class="style3">
                    <asp:RadioButtonList ID="rdbGender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="rdbGender" ErrorMessage="Select Gender"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    Marital</td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="rdbMarital" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Single</asp:ListItem>
                        <asp:ListItem>Married</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="rdbMarital" ErrorMessage="Select MaritalStatus"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Dept</td>
                <td class="style3">
                    <asp:DropDownList ID="ddlDept" runat="server" Height="16px" Width="130px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="ddlDept" ErrorMessage=" Select Department" 
                        InitialValue="--select--"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    UserName</td>
                <td class="style3">
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtusername" ErrorMessage="Enter UserName" 
                        ValidationGroup="check"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtusername" ErrorMessage="Min 5 Max 12 Characters" 
                        ValidationExpression="([A-Za-z0-9]{5,12})" ValidationGroup="check"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="btnCheck" runat="server" Text="CheckAvailability" 
                        ValidationGroup="check" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtpwd" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Retype</td>
                <td class="style3">
                    <asp:TextBox ID="txtretype" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtpwd" ControlToValidate="txtretype" 
                        ErrorMessage="Password mismatch"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Email</td>
                <td class="style3">
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="txtemail" ErrorMessage="Enter Correct emaild" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtemail" ErrorMessage="Enter EmailId"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Age</td>
                <td class="style3">
                    <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtage" ErrorMessage="Enter Age"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" 
                        ControlToValidate="txtage" ErrorMessage="Age between 21-60" MaximumValue="60" 
                        MinimumValue="21" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Salary</td>
                <td class="style3">
                    <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="txtsalary" ErrorMessage="Enter Salary"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtsalary" ErrorMessage="Salary between 5000-20000" 
                        MaximumValue="20000" MinimumValue="5000" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    PhoneNumber</td>
                <td class="style3">
                    <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        ControlToValidate="txtphone" ErrorMessage="Entrer PhoneNumber"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                        ControlToValidate="txtphone" ErrorMessage="Enter Correct number" 
                        ValidationExpression="([0-9]{7,10})"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                        onclick="btnSubmit_Click" />
                    <asp:Button ID="btnReset" runat="server" Text="Reset" 
                        CausesValidation="False" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style4">
                    <strong>Validation Summary</strong></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    </td>
                <td class="auto-style8">
                    <strong>Custom Validator</strong></td>
                <td class="auto-style9">
                    </td>
            </tr>
            <tr>
                <td class="style2">
                    BasicSalary</td>
                <td class="style5">
                    <asp:TextBox ID="txtbasic" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" 
                        ControlToValidate="txtbasic" ErrorMessage="Basic between 5000-8000" 
                        onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
