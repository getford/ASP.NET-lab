<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
    </p>
    <p>
        <asp:Button ID="Button_get" runat="server" OnClick="Button_get_Click" Text="GET" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label_get" runat="server" Text="Label get"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button_post" runat="server" OnClick="Button_post_Click" Text="POST" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label_post" runat="server" Text="Label post"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button_put" runat="server" Text="PUT" OnClick="Button_put_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label_put" runat="server" Text="Label put"></asp:Label>
    </p>
    <p>
        <br />
        <asp:TextBox ID="TextBox_X" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; +&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Y" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_sum" runat="server" Text="Let's sum" OnClick="Button_sum_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label_result" runat="server" Text="result"></asp:Label>
    </p>
    <p>
    </p>

</asp:Content>
