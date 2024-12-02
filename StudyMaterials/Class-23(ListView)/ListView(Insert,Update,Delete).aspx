<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListView(Insert,Update,Delete).aspx.cs" Inherits="Class_23_ListView_ListView_Insert_Update_Delete_" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                   <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1"  
                        onitemcommand="ListView1_ItemCommand" DataKeyNames="cid"  >


                   <LayoutTemplate>
                     <table runat="server">
                     <tr runat="server">
                         <td runat="server">
                             <table ID="itemPlaceholderContainer" runat="server" border="1" 
                                 style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                 <tr runat="server" style="background-color: #FFFBD6;color: #333333;">
                                     <th runat="server">
                                         cid</th>
                                     <th runat="server">
                                         FirstName</th>
                                     <th runat="server">
                                         LastName</th>
                                     <th runat="server">
                                         ContactType</th>
                                 </tr>
                                 <tr ID="itemPlaceholder" runat="server">
                                 </tr>
                             </table>
                         </td>
                     </tr>
                     <tr runat="server">
                         <td runat="server" 
                             style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                             <asp:DataPager ID="DataPager1" runat="server">
                                 <Fields>
                                     <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                                         ShowLastPageButton="True" />
                                 </Fields>
                             </asp:DataPager>
                         </td>
                         </tr>
                    </table>

                    </LayoutTemplate>


                <ItemTemplate>
                    <tr style="background-color: #FFFBD6;color: #333333;">
                        <td><asp:Label runat="server" ID="cidLabel" Text='<%# Eval("cid") %>'></asp:Label></td>
                        <td><asp:Label runat="server" ID="FirstNameLabel" Text='<%# Eval("FirstName") %>'></asp:Label></td>
                        <td><asp:Label runat="server" ID="LastNameLabel" Text='<%# Eval("LastName") %>'></asp:Label></td>
                        <td>
                            <asp:Label ID="ContactTypeLabel" runat="server" 
                                Text='<%# Eval("ContactType") %>' />
                        </td>
                    </tr>
                </ItemTemplate>

                <AlternatingItemTemplate>
                    <tr style="background-color:#FAFAD2; color: #284775;">
                        <td><asp:Label runat="server" ID="cidLabel" Text='<%# Eval("cid") %>'></asp:Label></td>
                        <td><asp:Label runat="server" ID="FirstNameLabel" Text='<%# Eval("FirstName") %>'></asp:Label></td>
                        <td><asp:Label runat="server" ID="LastNameLabel" Text='<%# Eval("LastName") %>'></asp:Label></td>
                        <td>
                            <asp:Label ID="ContactTypeLabel" runat="server" 
                                Text='<%# Eval("ContactType") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>



                <EditItemTemplate>
                    <tr style="background-color: #FFCC66;color: #000080;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                            Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                            Text="Cancel" />
                    </td>
                    <td>
                        <asp:Label ID="cidLabel1" runat="server" Text='<%# Eval("cid") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="FirstNameTextBox" runat="server" 
                            Text='<%# Bind("FirstName") %>'></asp:TextBox>
                      </td>
                        <td>   
                            <asp:TextBox ID="LastNameTextBox" runat="server" 
                                Text='<%# Bind("LastName") %>' />
                        </td>
                    
                        <td>
                            <asp:TextBox ID="ContactTypeTextBox" runat="server" 
                                Text='<%# Bind("ContactType") %>' />
                        </td>
                    
                    </tr>
                </EditItemTemplate>


                       <EmptyDataTemplate>
                           <table runat="server" 
                               style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                               <tr>
                                   <td>
                                       No data was returned.</td>
                               </tr>
                           </table>
                       </EmptyDataTemplate>


            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                            Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                            Text="Clear" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td><asp:TextBox ID="FirstNameTextBox" runat="server" 
                            Text='<%# Bind("FirstName") %>'></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="LastNameTextBox" runat="server" 
                            Text='<%# Bind("LastName") %>' />
                    </td>
                    
                    <td>
                        <asp:TextBox ID="ContactTypeTextBox" runat="server" 
                            Text='<%# Bind("ContactType") %>' />
                    </td>
                    
                </tr>
            </InsertItemTemplate>
   
                       <SelectedItemTemplate>
                           <tr style="background-color: #FFCC66;font-weight: bold;color: #000080;">
                               <td>
                                   <asp:Label ID="cidLabel" runat="server" Text='<%# Eval("cid") %>' />
                               </td>
                               <td>
                                   <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                               </td>
                               <td>
                                   <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                               </td>
                               <td>
                                   <asp:Label ID="ContactTypeLabel" runat="server" 
                                       Text='<%# Eval("ContactType") %>' />
                               </td>
                           </tr>
                       </SelectedItemTemplate>
   
        </asp:ListView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:db_aspsylabusConnectionString3 %>" 
            SelectCommand="SELECT * FROM [Contacts]" >
        </asp:SqlDataSource>

                    
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
