<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="MatchSchedule.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
      .form-container {
           
            max-width: 600px;
            min-width:500px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 8px;
            background-color: #f9f9f9;
             margin-top:60px;
             /*margin-bottom:60px;*/
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
            #ContentPlaceHolder1_ddldistrict  {
             margin: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="form-container">
       <div class="form-group-edit">
             <label for="ddldistrict">District</label>

                <asp:DropDownList ID="ddldistrict" runat="server" AutoPostBack="True" Width="554px"  class="form-control" OnSelectedIndexChanged="ddldistrict_SelectedIndexChanged">
                </asp:DropDownList>
           </div>
        <div class="form-group-edit">
            <label for="ddlplace">Place</label>
            
                <asp:DropDownList ID="ddlplace" runat="server"  class="form-control" Width="554px">
                </asp:DropDownList>
           </div>
        <div class="form-group-edit">
            <label for="txtvenue">Venue Location</label>
            
                <asp:TextBox ID="txtvenue" runat="server" class="form-control" Width="554px"></asp:TextBox>
            </div>
        <div class="form-group-edit">
            <label for="txtaddress">Address</label>
            
                <asp:TextBox ID="txtaddress" runat="server" Height="90px" class="form-control" Width="554px"></asp:TextBox>
            </div>
        <div class="form-group-edit">
             <label for="txtstartdate">Start Date</label>
           
                <asp:TextBox ID="txtstartdate" runat="server" TextMode="Date"  class="form-control" Width="554px"></asp:TextBox>
           </div>
        <div class="form-group-edit">
          <label for="txtenddate">End Date</label>
            
                <asp:TextBox ID="txtenddate" runat="server" TextMode="Date" class="form-control" Width="554px"></asp:TextBox>
           </div>
            
            <div class="form-actions">
                <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" Width="100px" class="btn btn-primary" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" OnClick="btncancel_Click" class="btn btn-secondary" />
                <asp:Button ID="btnshow" runat="server" OnClick="btnshow_Click1" Text="Show" class="btn btn-secondary"/>
           </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                <asp:GridView ID="gdms" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" OnPageIndexChanging="gdmatchschedule_PageIndexChanging" OnRowCommand="gdmatchschedule_RowCommand" PageSize="5" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="district_name" HeaderText="DistrictName" />
                        <asp:BoundField DataField="place_name" HeaderText="PlaceName" />
                        <asp:BoundField DataField="schedule_venue" HeaderText="VenueLocation" />
                        <asp:BoundField DataField="schedule_address" HeaderText="Address" />
                        <asp:BoundField DataField="schedule_start" HeaderText="StartDate" />
                        <asp:BoundField DataField="schedule_end" HeaderText="EndDate" />
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:Button ID="btndelete" runat="server" CommandArgument='<%# Eval("schedule_id") %>' CommandName="del" Text="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:Button ID="btnedit" runat="server" CommandArgument='<%# Eval("schedule_id") %>' CommandName="ed" Text="Edit" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
            </div>
        </div>
</asp:Content>

