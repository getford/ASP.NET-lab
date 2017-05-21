<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="L10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <script type="text/javascript">
            function add() {
                let x = $get("TextBoxX").value;
                let y = $get("TextBoxY").value;
                L10.WebService1.Add(x, y, setResult);
            }
            function sub() {
                let x = $get("TextBoxX").value;
                let y = $get("TextBoxY").value;
                L10.WebService1.Sub(x, y, setResult);
            }
            function mul() {
                let x = $get("TextBoxX").value;
                let y = $get("TextBoxY").value;
                L10.WebService1.Mul(x, y, setResult);
            }
            function setResult(result) {
                $get("TextBoxResult").value = result;
            }
        </script>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/WebService1.asmx" />
            </Services>
        </asp:ScriptManager>
        <div>
            <br />
            X<asp:TextBox ID="TextBoxX" runat="server" Width="200px"></asp:TextBox>
            <br />
            Y<asp:TextBox ID="TextBoxY" runat="server" Width="200px"></asp:TextBox>
            <asp:TextBox ID="TextBoxResult" runat="server" ReadOnly="true"></asp:TextBox>
            <div>
                <asp:Button ID="ButtonAdd" runat="server" Text="+" OnClientClick="add(); return false;" Style="margin: 0 30px" />
                <asp:Button ID="ButtonSub" runat="server" Text="-" OnClientClick="sub(); return false;" Style="margin: 0 30px" />
                <asp:Button ID="ButtonMul" runat="server" Text="*" OnClientClick="mul(); return false;" Style="margin: 0 30px" />
                <asp:Label ID="Label1" runat="server" Text="Результат" Style="font-size: x-large"></asp:Label>
                
                <br />
                <asp:Button ID="ButtonSavetoCookie" runat="server" Text="SavetoCookie" OnClick="ButtonSavetoCookie_Click" />
                <br />
                <!--<asp:Button ID="ButtonSavetoApplication" runat="server" Text="SavetoApplication" OnClick="ButtonSavetoApplication_Click" UseSubmitBehavior="false" />-->
            </div>
        </div>
    </form>
</body>
</html>
