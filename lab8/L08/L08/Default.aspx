<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="L08._Default" %>

<%@ Register Src="~/StudentControl.ascx" TagPrefix="uc1" TagName="StudentControl" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:StudentControl runat="server" ID="StudentControl" buttonCancelText="Cancel" />


</asp:Content>

