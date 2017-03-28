using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lb5_elements
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // 1
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = TextBox2.Text.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label3.Text = TextBox3.Text.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = (MultiView1.ActiveViewIndex + 1) % 3;
        }

        // 2
        protected void Button5_Click(object sender, EventArgs e)
        {
            switch (AdRotator1.KeywordFilter)
            {
                case "b1":
                    AdRotator1.KeywordFilter = "b2";
                    break;
                case "b2":
                    AdRotator1.KeywordFilter = "";
                    break;
                default:
                    AdRotator1.KeywordFilter = "b1";
                    break;
            }
        }

        // 3
        protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Label_result.Text = $"<br/><hr/><b>Вы выбрали: " +
                $"</b><br>Язык программирования: <em>{lstLanguage.Text.ToString()}</em><br>" +
            $"Число сотрудников: <em>{txtEmpCount.Text.ToString()}</em><br>" +
            $"Городов: <em>{txtLocCount.Text.ToString()}</em><br>Программы: <em>";
            foreach (ListItem item in lstTools.Items)
            {
                if (item.Selected)
                    Label_result.Text += item + " ";
            }
            Label_result.Text += "</em><br>";
        }

        // 4
        protected void TreeView1_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            TreeNode tn = TreeView1.SelectedNode;
            Response.Write(tn.Value + (tn.Checked ? "Выбран" : "Отозван"));
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {

        }

        // 5
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            Menu menu = (Menu)sender;
            Response.Write(menu.SelectedItem.Text + " " + menu.SelectedItem.Value);
        }
    }
}

/*
Задание 5.Элемент Menu

20.	В области третьего View элемента MultyView  создайте элемент Menu.
21.	Menu должен  иметь не  менее  3х уровней, быть статическим, вертикальным и иметь стиль не Classic.
22.	Как минимум для одного из пунктов Menu должен быть установлен ToolTip.
23.	Обработайте выбор узлов пунктов Menu,  выведите на форму значения соответствующие  выбранным пунктом.
*/
