<%@ Page Title="" Language="C#" MasterPageFile="~/Club/ClubMaster.master" AutoEventWireup="true" CodeFile="PlayerGallery.aspx.cs" Inherits="Club_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 144px;
        }
        .auto-style3 {
            width: 401px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style6 {
            width: 401px;
        }
        .move {
            margin-top: 80px;
        }
        .auto-style7 {
            width: 316px;
        }
         #ContentPlaceHolder1_ddlplayername {
             margin: 0;
        }
          #ContentPlaceHolder1_filephoto {
             margin: 0;
        }
           #ContentPlaceHolder1_btnsubmit {
             margin: 0;
        }
            #ContentPlaceHolder1_btncancel{
             margin: 0;
        }
             #ContentPlaceHolder1_btnshow {
             margin: 0;
        }

        .auto-style8 {
            width: 69px;
        }

        .auto-style9 {
            width: 246px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="move" >
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
           <%-- <asp:Button ID="Button1" runat="server" Text="Button" />--%>
            <td class="auto-style9">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">PlayerName</td>
            <td class="auto-style9">
                <asp:DropDownList ID="ddlplayername" runat="server" Width="200px" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlplayername" ErrorMessage="Select Name" InitialValue="--Select--"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">Photo</td>
            <td class="auto-style9">
                <asp:FileUpload ID="filephoto" runat="server" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="100px" style="height: 26px" BackColor="#0099FF" ForeColor="White" BorderColor="White" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" OnClick="btncancel_Click" BackColor="#999999" ForeColor="White" BorderColor="White" />
                <asp:Button ID="btnshow" runat="server" OnClick="btnshow_Click" Text="Show" BackColor="#666666" ForeColor="White" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
    <p>
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowPaging="True" PageSize="4" >
                    <Columns>
                        <asp:BoundField DataField="p_name" HeaderText="PlayerName" />
                        <asp:TemplateField HeaderText="PhotoGallery">
                            <ItemTemplate>
                                <img src="../Assests/Playerdoc/<%#Eval("pg_photo") %>" width="50" height="50" />
                              
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>  <img src="../Assests/Playerdoc/<%#Eval("pg_photo") %>" width="50" height="50" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("p_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btndelete" runat="server" CommandArgument='<%# Eval("p_id") %>' CommandName="del" Text="Delete" />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
         </div>
</asp:Content>

