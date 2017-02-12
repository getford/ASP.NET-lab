<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
        Элемент HTMLInputReset&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_reset" runat="server" Text="reset" />
        <br />
        Элемент HTMLInputButton&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_button" runat="server" Text="button" />
        <br />
        Элемент HTMLInputSubmit&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_submit" runat="server" Text="submit" />
        <br />
        Элемент HTMLInputFile
            <asp:FileUpload ID="FileUpload_file" runat="server" />
        <br />
        Элемент HTMLInputText&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_text" runat="server"></asp:TextBox>
        <br />
        Элемент HTMLInputPassword&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_password" runat="server" Text="Button" />
        <br />
        Элемент HTMLInputCheckBox  
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <br />
        Элемент HTMLInputRadioButton   
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <asp:RadioButton ID="RadioButton2" runat="server" />
        <br />
        Элемент HTMLInputTextArea       
        <asp:TextBox ID="TextBox1" runat="server" Height="123px" Width="265px"></asp:TextBox>
        <br />
        Элемент HTMLSelect<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="189px"></asp:DropDownList>
        <br />
    </p>
    <p>
        &nbsp;
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>

</asp:Content>
