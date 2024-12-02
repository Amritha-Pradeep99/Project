<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageMap.aspx.cs" Inherits="Class_22_ImageMap_ImageMap" %>

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
            width: 130px;
        }
        .style3
        {
            width: 130px;
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3">
                    <strong>ImageMap</strong></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:ImageMap ID="ImageMap1" runat="server" 
                        ImageUrl="~/StudyMaterials/Class-22(ImageMap)/image/aspnet_imagemap.jpg" 
                        onclick="ImageMap1_Click">
                        
                        <asp:RectangleHotSpot AlternateText="Facebook" Bottom="62" 
                            HotSpotMode="Navigate" Left="14" NavigateUrl="http://www.facebook.com" 
                            Right="152" Target="_blank" Top="11" />

                        <asp:RectangleHotSpot AlternateText="Twitter" Bottom="61" 
                            HotSpotMode="Navigate" Left="156" NavigateUrl="http://www.twitter.com" 
                            Right="306" Target="_blank" Top="11" />
            
                        <asp:CircleHotSpot AlternateText="WordPress" HotSpotMode="PostBack" 
                            PostBackValue="WordPress" Radius="41" X="50" Y="118" />
            
                        <asp:CircleHotSpot AlternateText="BMW" HotSpotMode="PostBack" 
                            PostBackValue="BMW" Radius="41" X="155" Y="121" />
      
                        <asp:CircleHotSpot AlternateText="Windows" HotSpotMode="PostBack" 
                            PostBackValue="Windows" Radius="44" X="266" Y="122" />
            
                        <asp:PolygonHotSpot AlternateText="Star" HotSpotMode="PostBack" 
                            PostBackValue="Star" 
                            Coordinates="108,217, 141,210, 157,181, 173,210, 207,217, 184,242, 188,276, 158,261, 127,275, 131,243" 
                            NavigateUrl="Star" />

                    </asp:ImageMap>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
