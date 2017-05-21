<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="L11._Default" %>

<%@ Register Src="~/StudentControl.ascx" TagPrefix="uc1" TagName="StudentControl" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <uc1:StudentControl runat="server" ID="StudentControl" />
       
    </div>

</asp:Content>
