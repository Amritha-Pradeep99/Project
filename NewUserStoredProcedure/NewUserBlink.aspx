<%@ Page Title="" Language="C#" MasterPageFile="~/NewUserStoredProcedure/NewUserStoredProcedureMasterPage.master" AutoEventWireup="true" CodeFile="NewUserBlink.aspx.cs" Inherits="NewUserStoredProcedure_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            height: 36px;
        }
    </style>

    *** Blink Code ***


     <script  type="text/javascript">
         var hexvalues
 = Array("A", "B", "C", "D", "E", "F", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9");

         function flashtext() {

             var colour = '#';
             for (var counter = 1; counter <= 6; counter++) {
                 var hexvalue = hexvalues[Math.floor(hexvalues.length * Math.random())];

                 colour = colour + hexvalue;

             }
             document.getElementById("flashingtext").style.color = colour;
         }

         setInterval("flashtext()", 500);



</script>




*** Blink Code ***

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="background-color: #C0C0C0">
                         
*** Blink Code ***
  

                 <blink></blink>New UserName is 
                <div id="flashingtext" style="font-size:25px;">
    <asp:Label ID="lblMarque" runat="server" ></asp:Label> 
</div>
                

*** Blink Code ***
                </td>
            
        </tr>
        <tr>
            <td class="style3" style="font-size: x-large; color: #9900CC">
                Welcome
                <asp:Label ID="lblUsername" runat="server"></asp:Label>
            </td>
            <td class="style3">
            </td>
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

