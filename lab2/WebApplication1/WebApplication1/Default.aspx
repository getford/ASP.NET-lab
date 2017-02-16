<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        &nbsp;
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;       
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
&nbsp;&nbsp;&nbsp;       
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
    </p>
    <p>
        <asp:Label ID="Label_len" runat="server" Text="label leng"></asp:Label>
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:Label ID="viewState" runat="server" Text="view state"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button_system_info" runat="server" OnClick="Button_sys_info" Text="Button info" />
    </p>
<p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    
</asp:Content>
