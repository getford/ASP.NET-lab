<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudentControl.ascx.cs" Inherits="L08.StudentControl" %>
<script type="text/javascript">
    function LookUpStock() {
        if (Page_ClientValidate()) {
            let list = document.getElementById("MainContent_StudentControl_RadioButtonListSex");
            let inputs = list.getElementsByTagName("input");
            let selected;
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i].checked) {
                    selected = inputs[i];
                    break;
                }
            }
            let data = JSON.stringify(
                {
                    "Family": $get("MainContent_StudentControl_TextBoxFamily").value,
                    "Name": $get("MainContent_StudentControl_TextBoxName").value,
                    "Patro": $get("MainContent_StudentControl_TextBoxPatro").value,
                    "Date": $get("MainContent_StudentControl_TextBoxDate").value,
                    "Sex": selected.value,
                    "Name": $get("MainContent_StudentControl_TextBoxName").value,
                    "Faculty": $get("MainContent_StudentControl_DropDownListFaculty").value,
                    "Year": Number($get("MainContent_StudentControl_TextBoxYear").value),
                    "Group": Number($get("MainContent_StudentControl_TextBoxGroup").value)
                });
            CallServer(data, "");
        }
        return false;
    }
    function ReceiveServerData(rValue) {
        $get("MainContent_StudentControl_LabelResult").textContent = rValue;
    }
</script>
<asp:FormView ID="FormView1" runat="server"></asp:FormView>
<div>
    <h1>&nbsp;</h1>
    <p>
        <asp:TextBox ID="TextBoxFamily" runat="server" placeholder="Фамилия" Width="189px"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBoxName" runat="server" placeholder="Имя" Width="190px"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBoxPatro" runat="server" placeholder="Отчество" Width="191px"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBoxDate" runat="server" placeholder="Дата рождения" Width="193px"></asp:TextBox>
    </p>
    <p>
        <asp:RadioButtonList ID="RadioButtonListSex" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="0" Text="Ж"></asp:ListItem>
            <asp:ListItem Value="1" Text="М" Selected="true"></asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        Факультет
       
        <asp:DropDownList ID="DropDownListFaculty" runat="server" Height="16px" Width="125px">
            <asp:ListItem Value="ИТ"></asp:ListItem>
            <asp:ListItem Value="ПИМ"></asp:ListItem>
            <asp:ListItem Value="ХТиТ"></asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:TextBox ID="TextBoxYear" runat="server" placeholder="Год поступления"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBoxGroup" runat="server" placeholder="Группа"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonCancel" runat="server" Text="Отказаться" CausesValidation="false" UseSubmitBehavior="false" Visible="false" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Введите фаилию" ControlToValidate="TextBoxFamily" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Введите № группы" ControlToValidate="TextBoxGroup" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Введите Имя" ControlToValidate="TextBoxName" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="введите отчество" ControlToValidate="TextBoxPatro" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Введите дату рождения" ControlToValidate="TextBoxDate" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Введите год поступления" ControlToValidate="TextBoxYear" Display="None"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="день рождения error" Display="None" Operator="LessThan" Type="Date" ControlToValidate="TextBoxDate"></asp:CompareValidator>


        <asp:RangeValidator ID="RangeValidatorTextBoxGroup" runat="server" ErrorMessage="№ группы в диапазоне 1 100" ControlToValidate="TextBoxGroup" MaximumValue="100" MinimumValue="1" Type="Integer" Display="None"></asp:RangeValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <p>
        <asp:Button runat="server" ID="ButtonEnter" OnClientClick="LookUpStock();return false;" UseSubmitBehavior="false" Text="Send data" />

        <asp:Label ID="LabelResult" runat="server" Text="Label"></asp:Label>
</div>
