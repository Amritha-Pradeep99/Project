<%@ Page Title="" Language="C#" MasterPageFile="~/Club/ClubMaster.master" AutoEventWireup="true" CodeFile="ApplySchedule.aspx.cs" Inherits="Club_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 71px;
        }
        .auto-style3 {
            height: 30px;
        }
        .auto-style4 {
            width: 258px;
        }
        .auto-style5 {
            height: 71px;
            width: 258px;
        }
        .auto-style6 {
            height: 30px;
            width: 258px;
        }
         .move {
            margin-top: 120px;
        }
        .auto-style7 {
            width: 195px;
        }
        .auto-style8 {
            height: 71px;
            width: 195px;
        }
        .auto-style9 {
            height: 30px;
            width: 195px;
        }
        .auto-style10 {
            width: 103px;
        }
        .auto-style11 {
            height: 71px;
            width: 103px;
        }
        .auto-style12 {
            height: 30px;
            width: 103px;
        }
        .auto-style13 {
            height: 16px;
        }
        .auto-style14 {
            height: 16px;
            width: 195px;
        }
        .auto-style15 {
            height: 16px;
            width: 103px;
        }
        .auto-style16 {
            height: 16px;
            width: 258px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="move" >
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style2">
                <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                    <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <Fields>
                        <asp:BoundField DataField="schedule_venue" HeaderText="Venue" />
                        <asp:BoundField DataField="schedule_address" HeaderText="Address" />
                        <asp:BoundField DataField="schedule_start" HeaderText="StartDate" />
                        <asp:BoundField DataField="schedule_end" HeaderText="EndDate" />
                        <asp:BoundField DataField="place_name" HeaderText="Place" />
                        <asp:BoundField DataField="place_pincode" HeaderText="Pincode" />
                        <asp:BoundField DataField="district_name" HeaderText="District" />
                    </Fields>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                </asp:DetailsView>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style14"></td>
            <td class="auto-style15"></td>
            <td class="auto-style16"></td>
            <td class="auto-style13">
                <asp:Button ID="btnapplynow" runat="server" OnClick="btnapplynow_Click" Text="ApplyNow" />
            </td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Label ID="lblmessage" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
         </div>
</asp:Content>

