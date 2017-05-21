<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="PageWithMaserPage.aspx.cs" Inherits="L09.PageWithMaserPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div>
        <p>Текст Текст Текст</p>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Calendar runat="server"></asp:Calendar>
    </div>
</asp:Content>
