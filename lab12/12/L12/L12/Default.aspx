<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="L12._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <script type="text/javascript">
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_initializeRequest(InitializeRequest);

            function InitializeRequest(sender, args) {
                if (prm.get_isInAsyncPostBack()) {
                    args.set_cancel(true);
                }
            }

            function AbortPostBack() {
                alert("AbortPostBack()");
                if (prm.get_isInAsyncPostBack()) {
                    prm.abortPostBack();
                }
            }
        </script>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <p>
                    <asp:Button ID="Button1" runat="server" Text="AjaxTime" OnClick="Button1_Click" UseSubmitBehavior="false" />
                    <asp:Label ID="Label1" runat="server" Text="Time"></asp:Label>
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            Подождите 3 секунды...
                            <input id="ButtonAbortPostBack" type="button" value="Отмена" onclick="AbortPostBack()" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </p>
                <p>
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <asp:Label ID="LabelTextBox" runat="server" Text="Time"></asp:Label>
                </p>
                <p>
                    <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="true" />
                    <asp:Label ID="LabelCheckBox" runat="server" Text="Time"></asp:Label>
                </p>
                <p>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="true" RepeatDirection="Horizontal">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Label ID="LabelRadioButtons" runat="server" Text="Time"></asp:Label>
                </p>
                <asp:Timer ID="Timer1" runat="server" Interval="3000" OnTick="Timer1_Tick"></asp:Timer>
                <p>
                    <asp:Label ID="LabelTimer1" runat="server" Text="Timer3000"></asp:Label>
                </p>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ButtonTrigger" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:Button ID="ButtonTrigger" runat="server" Text="ButtonForTrigger" OnClick="Button1_Click" />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Timer ID="Timer2" runat="server" Interval="5000" OnTick="Timer2_Tick"></asp:Timer>
                <asp:Label ID="LabelTimer2" runat="server" Text="Timer5000"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
