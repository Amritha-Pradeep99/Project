<%@ Page Title="" Language="C#" MasterPageFile="~/Test/TestMaster.master" AutoEventWireup="true" CodeFile="ImageMap.aspx.cs" Inherits="Test_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1" >
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                    <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/StudyMaterials/Class-22(ImageMap)/image/aspnet_imagemap.jpg" onclick="ImageMap1_Click">
                        
                    <asp:RectangleHotSpot AlternateText="Facebook" Bottom="62" HotSpotMode="Navigate" Left="14" NavigateUrl="http://www.facebook.com" Right="152" Target="_blank" Top="11" PostBackValue="Facebook" />

                    <asp:RectangleHotSpot AlternateText="Twitter" Bottom="61" HotSpotMode="Navigate" Left="156" NavigateUrl="http://www.twitter.com" Right="306" Target="_blank" Top="11" PostBackValue="Twitter" />
            
                    <asp:CircleHotSpot AlternateText="WordPress" HotSpotMode="Navigate" PostBackValue="WordPress" Radius="41" X="50" Y="118" NavigateUrl="https://wordpress.com/log-in/" />
            
                    <asp:CircleHotSpot AlternateText="BMW" HotSpotMode="Navigate"  PostBackValue="BMW" Radius="41" X="155" Y="121" NavigateUrl="https://www.mybmwaccount.com.au/?timeout=1" />
      
                    <asp:CircleHotSpot AlternateText="Windows" HotSpotMode="Navigate" PostBackValue="Windows" Radius="44" X="266" Y="122" NavigateUrl="https://account.microsoft.com/account/Account" Target="_blank" />
            
                    <asp:PolygonHotSpot AlternateText="Star" HotSpotMode="PostBack" PostBackValue="Star" Coordinates="108,217, 141,210, 157,181, 173,210, 207,217, 184,242, 188,276, 158,261, 127,275, 131,243" NavigateUrl="Star" />

                    </asp:ImageMap>
                </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
       
    </table>
</asp:Content>

