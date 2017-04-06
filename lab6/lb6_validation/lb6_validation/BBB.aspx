<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BBB.aspx.cs" Inherits="lb6_validation.BBB" %>

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
                Фамилия&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxF" runat="server"></asp:TextBox>
                <br />
                Имя&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxN" runat="server"></asp:TextBox>
                <br />
                Отчество&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxLN" runat="server"></asp:TextBox>
                <br />
                Дата&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxData" runat="server"></asp:TextBox>
                <br />
                E-mail&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxEMail" runat="server"></asp:TextBox>
                <br />
                Сумма&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxSum" runat="server"></asp:TextBox>
                <br />
                Пароль&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" />
                &nbsp;
               <hr />
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorF" runat="server" ErrorMessage="Введите фамилию" ControlToValidate="TextBoxF" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorF" runat="server" ErrorMessage="Фамилия должна быть только на русском языке и не более32" ControlToValidate="TextBoxF" Display="None" ValidationExpression="^[а-яА-ЯёЁъЪ]{1,32}$"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" ErrorMessage="Введите имя" ControlToValidate="TextBoxN" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" runat="server" ErrorMessage="Имя должна быть только на русском языке и не более32" ControlToValidate="TextBoxLN" Display="None" ValidationExpression="^[а-яА-ЯёЁъЪ]{1,32}$"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLName" runat="server" ErrorMessage="Введите Отчество" ControlToValidate="TextBoxN" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorLName" runat="server" ErrorMessage="Отчество должна быть только на русском языке и не более32" ControlToValidate="TextBoxLN" Display="None" ValidationExpression="^[а-яА-ЯёЁъЪ]{1,32}$"></asp:RegularExpressionValidator>
                <asp:CompareValidator ID="CompareValidatorDate" runat="server" ErrorMessage="Дата превышает сегодня" ControlToValidate="TextBoxData" Display="None" Operator="LessThan" Type="Date"></asp:CompareValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEMail" runat="server" ErrorMessage="Invalid e-mail" Display="None" ControlToValidate="TextBoxEMail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:RangeValidator ID="RangeValidatorSum" runat="server" ErrorMessage="Сумма вне диапазона [1000 2000]" ControlToValidate="TextBoxSum" Display="None" MaximumValue="2000" MinimumValue="1000" Type="Integer"></asp:RangeValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorPass1" runat="server" ErrorMessage="Строчные и прописные латинские буквы, цифры, спецсимволы. Минимум 8 символов" ControlToValidate="TextBoxPass" Display="None" ValidationExpression="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$"></asp:RegularExpressionValidator>
                <asp:CustomValidator ID="CustomValidatorPass" runat="server" ErrorMessage="Not unique symbols in password" ControlToValidate="TextBoxPass" Display="None" OnServerValidate="CustomValidatorPass_ServerValidate"></asp:CustomValidator>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
