<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="L07._Default"  %>
<%@ OutputCache Duration="10" VaryByParam="none"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>

           <div>
       <asp:Substitution ID="Substitution1" runat="server" MethodName="GetDate"/>
    </div>
        
    </div>

</asp:Content>
