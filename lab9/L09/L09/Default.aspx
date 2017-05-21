<%@ Page Title="Home Page" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="L09._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="button">
        <asp:Button CssClass="button" ID="Button1" runat="server" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text"></asp:Label>
    </div>

</asp:Content>
