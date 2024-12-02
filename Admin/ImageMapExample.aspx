<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="ImageMapExample.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/StudyMaterials/Class-22(ImageMap)/image/aspnet_imagemap.jpg" OnClick="ImageMap1_Click">
                    <asp:RectangleHotSpot AlternateText="facebook" Bottom="62" HotSpotMode="Navigate" Left="14" NavigateUrl="http://www.facebook.com" Right="151" Target="_blank" Top="11" />
                    <asp:RectangleHotSpot AlternateText="twitter" Bottom="62" HotSpotMode="Navigate" Left="158" NavigateUrl="http://www.twitter.com" Right="308" Target="_blank" Top="12" />
                    <asp:CircleHotSpot AlternateText="WordPress" HotSpotMode="Navigate" NavigateUrl="https://wordpress.com/" Radius="41" X="18" Y="115" />
                    <asp:CircleHotSpot AlternateText="BMW" HotSpotMode="Navigate" NavigateUrl="https://www.bmw.in/en/index.html" Radius="41" X="155" Y="121" />
                    <asp:CircleHotSpot AlternateText="Windows" HotSpotMode="Navigate" NavigateUrl="https://www.microsoft.com/en-in/windows?r=1" Radius="44" X="266" Y="122" />
                    <asp:PolygonHotSpot AlternateText="Star" Coordinates="108,217, 141,210, 157,181, 173,210, 207,217, 184,242, 188,276, 158,261, 127,275, 131,243" HotSpotMode="PostBack" NavigateUrl="Star" PostBackValue="Star" />
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
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

