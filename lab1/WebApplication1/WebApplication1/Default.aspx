<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:CheckBox ID="CheckBox1" runat="server" />
    </p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

</asp:Content>
