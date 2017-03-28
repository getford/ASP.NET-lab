<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lb5_elements._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                &nbsp;<asp:Label ID="Label1" runat="server" Text="view1"></asp:Label>
                <br />
                <br />
                <asp:Wizard ID="Wizard1" runat="server" BackColor="#E6E2D8" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" OnActiveStepChanged="Wizard1_ActiveStepChanged" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="434px">
                    <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                    <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
                    <SideBarButtonStyle ForeColor="White" />
                    <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
                    <SideBarTemplate>
                        <asp:DataList ID="SideBarList" runat="server">
                            <ItemTemplate>
                                <asp:LinkButton ID="SideBarButton" runat="server" ForeColor="White"></asp:LinkButton>
                            </ItemTemplate>
                            <SelectedItemStyle Font-Bold="True" />
                        </asp:DataList>
                    </SideBarTemplate>
                    <StepStyle BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" />
                    <WizardSteps>
                        <asp:WizardStep runat="server" Title="Шаг 1">
                            <h3>Язык программирования</h3>
                            Выберите используемый язык программирования:
                            <br />
                            <asp:DropDownList ID="lstLanguage" runat="server">
                                <asp:ListItem>C#</asp:ListItem>
                                <asp:ListItem>VB</asp:ListItem>
                                <asp:ListItem>J#</asp:ListItem>
                                <asp:ListItem>Java</asp:ListItem>
                                <asp:ListItem>C++</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Шаг 2">
                            <h3>Данные о компании</h3>
                            Количество сотрудников:
                    <asp:TextBox ID="txtEmpCount" runat="server" Width="46px"></asp:TextBox><br />
                            Количество городов:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtLocCount" runat="server" Width="46px"></asp:TextBox>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Шаг 3">
                            <h3>Программы</h3>
                            Необходимые лицензии:
                            <asp:CheckBoxList ID="lstTools" runat="server" Width="208px">
                                <asp:ListItem>Visual Studio 2017</asp:ListItem>
                                <asp:ListItem>Office 2016</asp:ListItem>
                                <asp:ListItem>Windows Server 2016</asp:ListItem>
                                <asp:ListItem>SQL Server 2016</asp:ListItem>
                            </asp:CheckBoxList>
                            &nbsp;
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Шаг 4">
                            Спасибо что заполнили эту анкету.<br />
                            <br />
                        </asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
                <asp:Label ID="Label_result" runat="server" Text="result"></asp:Label>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                &nbsp;<asp:Label ID="Label2" runat="server" Text="view2"></asp:Label>
                <br />
                <br />
                <asp:TreeView ID="TreeView1" runat="server" OnTreeNodeCheckChanged="TreeView1_TreeNodeCheckChanged" ShowCheckBoxes="Root" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" BorderStyle="None" ShowLines="True" Width="228px">
                    <Nodes>
                        <asp:TreeNode Text="1" ImageUrl="~/image/main.ico" ShowCheckBox="True" ToolTip="1111111">
                            <asp:TreeNode Text="1.1" ShowCheckBox="True" Value="1.1"></asp:TreeNode>
                            <asp:TreeNode ShowCheckBox="True" Text="1.2" Value="1.2"></asp:TreeNode>
                            <asp:TreeNode ShowCheckBox="True" Text="1.3" Value="1.3"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode ShowCheckBox="True" Text="2" Value="2">
                            <asp:TreeNode ShowCheckBox="True" Text="2.1" Value="2.1"></asp:TreeNode>
                            <asp:TreeNode ShowCheckBox="True" Text="2.2" Value="2.2"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="3" Value="3">
                            <asp:TreeNode Text="3.1" Value="3.1"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                </asp:TreeView>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
                &nbsp;<asp:Label ID="Label3" runat="server" Text="view3"></asp:Label>
                <br />
                <br />
                <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick" BackColor="White" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Small" ForeColor="Black" StaticSubMenuIndent="10px">
                    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#FFFBD6" />
                    <DynamicSelectedStyle BackColor="#FFCC66" />
                    <Items>
                        <asp:MenuItem Text="1" ToolTip="Menu1" Value="1">
                            <asp:MenuItem Text="1.1" Value="1.1"></asp:MenuItem>
                            <asp:MenuItem Text="1.2" Value="1.2"></asp:MenuItem>
                            <asp:MenuItem Text="1.3" Value="1.3"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="2" Value="2">
                            <asp:MenuItem Text="2.1" Value="2.1">
                                <asp:MenuItem Text="2.1.1" Value="2.1.1"></asp:MenuItem>
                                <asp:MenuItem Text="2.1.2" Value="2.1.2"></asp:MenuItem>
                            </asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="3" Value="3">
                            <asp:MenuItem Text="3.1" Value="3.1"></asp:MenuItem>
                        </asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                    <StaticMenuItemStyle BorderStyle="Solid" HorizontalPadding="5px" VerticalPadding="2px" />
                    
                    <StaticSelectedStyle BackColor="#FFCC66" />
                    <StaticItemTemplate>
                        <%# Eval("Text") %>
                    </StaticItemTemplate>
                    
                </asp:Menu>
            </asp:View>
        </asp:MultiView>
    </p>
    <p>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
    </p>
    <hr />
    <p>

        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/App_Data/XMLFile1.xml" />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/XMLFile1.xml"></asp:XmlDataSource>
        <br />
        <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Button5_Click" />
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>

</asp:Content>
