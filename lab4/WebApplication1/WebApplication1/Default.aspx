<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <p>HTMLInputReset<input id="Reset1" type="reset" value="reset" runat="server" onserverclick="Reset_ButtonClick" style="margin-left: 40px" /></p>
        <p>HTMLInputButton<input id="Button1" type="button" value="button" runat="server" onserverclick="ButtonClick" style="margin-left: 40px" /></p>
        <p>HTMLInputSubmit<input id="Submit1" type="submit" value="submit" runat="server" onserverclick="Submit_ButtonClick" style="margin-left: 40px" /></p>
        <p>HTMLInputFile<input id="File1" type="file" runat="server" onserverclick="File_ButtonClick" onserverchange="File_onserverchange" style="margin-left: 40px" /></p>
        <p>HTMLInputText<input id="Text1" type="text" runat="server" onserverchange="InputText_onserverchange" onserverclick="InputTextClick" style="margin-left: 40px" /></p>
        <p>HTMLInputPassword<input id="Password1" type="password" runat="server" onserverchange="Password_onserverchange" style="margin-left: 40px" /></p>
        <p>HTMLInputCheckBox<input id="Checkbox1" type="checkbox" runat="server" onserverchange="CheckBox_onserverchange" /></p>
        <p>
            HTMLInputRadioButton
           
            <input id="Radio1" type="radio" runat="server" onserverchange="radio1_onserverchange" />
            <input id="Radio2" type="radio" runat="server" onserverchange="radio2_onserverchange" />
        </p>
        <p>HTMLTextArea<textarea id="TextArea1" cols="20" rows="2" runat="server" onserverchange="textArea_onserverchange" style="margin-left: 40px"></textarea></p>

        <p>
            HTMLSelect
           
            <select id="Select1" runat="server" onserverchange="Select1_ServerChange" style="margin-left: 40px">
                <option value="1">1</option>
                <option value="2">2</option>
                <option value="3">3</option>
            </select>
        </p>
    </div>
</asp:Content>


