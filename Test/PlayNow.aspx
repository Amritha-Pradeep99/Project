<%@ Page Title="" Language="C#" MasterPageFile="~/Test/TestMaster.master" AutoEventWireup="true" CodeFile="PlayNow.aspx.cs" Inherits="Test_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <video width="400" height="300" controls>
   <source src="../Assests/Video/<%=videoname%>" type="video/mp4"/>
</video>
</asp:Content>

