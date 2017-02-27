<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="Button_get" runat="server" Text="get" OnClick="Button_get_Click"/>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button_post" runat="server" Text="post" OnClick="Button_post_Click"/>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button_options" runat="server" Text="options" OnClick="Button_options_Click"/>

</asp:Content>
