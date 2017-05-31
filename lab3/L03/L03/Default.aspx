<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="L03._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function me() {
            var oReq = new XMLHttpRequest();
            var sUrl = "http://localhost:61580/sum.zvy";
            oReq.open("POST", sUrl, true);
            oReq.onreadystatechange = function () {
                if (oReq.readyState == 4 && oReq.status == 200) {
                    document.getElementById("TextBoxResult").value = oReq.response;
                }
            }
            oReq.send("param1=" + document.getElementById("TextBox1").value + "&param2=" + document.getElementById("TextBox2").value);
        }
    </script>
    <div>
        <p>
            <asp:Button ID="ButtonGet" runat="server" Text="Get" OnClick="ButtonGet_Click" />
            &nbsp;&nbsp;&nbsp;
           
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Button ID="ButtonPost" runat="server" Text="Post" OnClick="ButtonPost_Click" />
            &nbsp;&nbsp;&nbsp;
           
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Put" OnClick="Button3_Click" />
            &nbsp;&nbsp;&nbsp;
           
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Button ID="ButtonSum" runat="server" Text="Sum" OnClick="ButtonSum_Click" />
            &nbsp;&nbsp;&nbsp; param1 =
           
            <asp:TextBox ID="TextBox1" runat="server" ClientIDMode="Static"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; param2 =
           
            <asp:TextBox ID="TextBox2" runat="server" ClientIDMode="Static"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; res =&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxResult" runat="server" ReadOnly="True" ClientIDMode="Static" Width="293px"></asp:TextBox>
        </p>
        <%--        <p>
            <input type="button" value="sum 2" onclick="me()" id="ButtonAjax">
        </p>--%>
    </div>
</asp:Content>
