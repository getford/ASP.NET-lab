<%@ Page Title="Contact" Language="C#" Theme="Skin1" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="L09.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button2" runat="server" Text="SkinDisabled" EnableTheming="false"/>
    <asp:Button ID="Button1" runat="server" Text="CommonSKin" />
    <asp:Button ID="Button3" runat="server" Text="SkinID1"  SkinID="SkinID1"/>
    <asp:Label ID="Label1" runat="server" Text="LabelCommonSkin"></asp:Label>
    
</asp:Content>
