<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Editing-in-Grid.aspx.cs" Inherits="Class_17_GridEditing_Editing_in_Grid" %>

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
            width: 75px;
        }
        .style3
        {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <strong>Command Field---Edit,Update,Cancel</strong></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Gender</td>
                <td>
                    <asp:RadioButtonList ID="rdbGender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Class</td>
                <td>
                    <asp:DropDownList ID="ddlClass" runat="server" Height="16px" Width="121px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                    <asp:Button ID="btnShow" runat="server" Text="Show" onclick="btnShow_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:GridView ID="grdStudent" runat="server" BackColor="LightGoldenrodYellow" 
                        BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
                        GridLines="None" AutoGenerateColumns="False" 
                        onrowcancelingedit="grdStudent_RowCancelingEdit" 
                        onrowdatabound="grdStudent_RowDataBound" 
                        onrowediting="grdStudent_RowEditing" DataKeyNames="studid" 
                        onrowupdating="grdStudent_RowUpdating">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        <Columns>
                            
                            
                            <asp:TemplateField HeaderText="Name">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtna" runat="server" Text='<%# Bind("studname") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblna" runat="server" Text='<%# Bind("studname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>



                            <asp:TemplateField HeaderText="Gender">
                                <EditItemTemplate>
                                    <asp:RadioButtonList ID="rdbgen" runat="server" RepeatDirection="Horizontal" >
                                        <asp:ListItem>Male</asp:ListItem>
                                        <asp:ListItem>Female</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <asp:TextBox ID="txtgen" runat="server" Text='<%# Bind("studgender") %>' Visible="false"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                   <asp:RadioButtonList ID="rdbgen" runat="server" RepeatDirection="Horizontal" Visible="false" >
                                        <asp:ListItem>Male</asp:ListItem>
                                        <asp:ListItem>Female</asp:ListItem>
                                    </asp:RadioButtonList>
                                       <asp:Label ID="lblgen" runat="server" Text='<%# Bind("studgender") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="Class">
                                <EditItemTemplate>
                                    <asp:DropDownList ID="ddlCls" runat="server" Height="16px" Width="88px" ></asp:DropDownList>
                                    <asp:TextBox ID="txtcls" runat="server" Text='<%# Bind("clsname") %>' Visible="false"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:DropDownList ID="ddlCls" runat="server" Height="16px" Width="88px" Visible="false"></asp:DropDownList>
                                    <asp:Label ID="lblcls" runat="server" Text='<%# Bind("clsname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>


                            <asp:CommandField ShowEditButton="True" />
                        </Columns>
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                            HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                        <SortedAscendingCellStyle BackColor="#FAFAE7" />
                        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                        <SortedDescendingCellStyle BackColor="#E1DB9C" />
                        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
