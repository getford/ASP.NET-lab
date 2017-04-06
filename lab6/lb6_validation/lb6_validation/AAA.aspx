<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AAA.aspx.cs" Inherits="lb6_validation.AAA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="ValidationGroup1" CausesValidation="True"></asp:TextBox>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="ValidationGroup1" CausesValidation="True">
                    <asp:ListItem Value="" Text=""></asp:ListItem>
                    <asp:ListItem Value="1" Text="1"></asp:ListItem>
                    <asp:ListItem Value="2" Text="2"></asp:ListItem>
                    <asp:ListItem Value="3" Text="3"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="ValidationGroup1" CausesValidation="True" />
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1TextBox" runat="server" ErrorMessage="TextBox is empty"
                    ValidationGroup="ValidationGroup1" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDropDownList" runat="server" ErrorMessage="DropDownList is empty"
                    ValidationGroup="ValidationGroup1" ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator>
                <hr />
            </div>
            <div>
                [100, 200]&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" ValidationGroup="ValidationGroup2"></asp:TextBox>
                <br />
                [01.01.2011, 31.12.2011]&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" ValidationGroup="ValidationGroup2"></asp:TextBox>
                <br />
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <br />
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Значение не в диапазоне [100 200]" MaximumValue="200"
                    MinimumValue="100" Type="Integer" ValidationGroup="ValidationGroup2" ForeColor="Red" ControlToValidate="TextBox2"></asp:RangeValidator>
                <br />
                <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Значение не в диапазоне [01.01.2011, 31.12.2011]"
                    MaximumValue="31.12.2011" MinimumValue="01.01.2011" Type="Date" ValidationGroup="ValidationGroup2" ForeColor="Red" ControlToValidate="TextBox3"></asp:RangeValidator>
                <hr />
            </div>
            <div>

                <asp:TextBox ID="TextBox4" runat="server" ValidationGroup="ValidationGroup3"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="ValidationGroup3"></asp:TextBox>
                <br />
                <asp:Button ID="Button3" runat="server" Text="Button" />
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Значение первого поля, должно быть больше второго"
                    ForeColor="Red" ValidationGroup="ValidationGroup3" ControlToCompare="TextBox4" ControlToValidate="TextBox5"
                    Operator="GreaterThan" Type="Date"></asp:CompareValidator>
                <hr />
            </div>
            <div>
                <asp:TextBox ID="TextBox6" runat="server" ValidationGroup="ValidationGroup4"></asp:TextBox>
                <br />
                <asp:Button ID="Button4" runat="server" Text="Button" />
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                    ErrorMessage="invalid e-mail" ControlToValidate="TextBox6"
                    ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ValidationGroup="ValidationGroup4" Display="Dynamic"></asp:RegularExpressionValidator>
                <hr />
            </div>
            <script>
                function customV(ctl, args) {
                    var n = parseInt(args.Value);
                    for (let i = 2; i <= n / 2; i++) {
                        if (n % i == 0) {
                            args.IsValid = false;
                            break;
                        }
                    }
                }
        </script>
            <div>

                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button5" runat="server" Text="Button" />
                <br />
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Число не простое"
                    ControlToValidate="TextBox7" OnServerValidate="CustomValidator2_ServerValidate"
                    ForeColor="Red" ClientValidationFunction="customV"></asp:CustomValidator>
            </div>
        </div>
    </form>
</body>
</html>
