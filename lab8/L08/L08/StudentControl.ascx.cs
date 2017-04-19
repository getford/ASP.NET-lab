using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*1.	Разработайте пользовательский элемент управления, который содержит поля для ввода следующих данных о студенте:
фамилия(textbox, string);
имя (textbox, string);
отчество (textbox, string);
дата рождения (textbox, date);
пол (radiobutton: м, ж);
факультет(dropdownlist, date);
группа (textbox, int);
год поступления (textbox, int).  
Кроме того, пользовательский элемент  управления должен содержать две кнопки: ввод, отказаться.
*/

namespace L08
{
    public partial class StudentControl : System.Web.UI.UserControl
    {
        public string name { get; set; }
        public string family { get; set; }
        public string patron { get; set; }
        public DateTime date { get; set; }
        public string sex { get; set; }
        public string faculty { get; set; }
        public int group { get; set; }
        public int year { get; set; }
        public string buttonEnterText { get; set; }
        public string buttonCancelText { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (buttonEnterText != null)
                ButtonEnter.Text = buttonEnterText;
            if (buttonCancelText != null)
                ButtonCancel.Text = buttonCancelText;
        }

        protected void ButtonEnter_Click(object sender, EventArgs e)
        {
            Label1.Text = $"<h4>{TextBoxFamily.Text}, {TextBoxName.Text}, {TextBoxPatro.Text}, {TextBoxDate.Text}, {RadioButtonListSex.SelectedValue},\n" +
                $" {DropDownListFaculty.SelectedValue}, {TextBoxGroup.Text}, {TextBoxYear}</h4>";
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            TextBoxDate.Text = string.Empty;
            TextBoxGroup.Text = string.Empty;
            TextBoxFamily.Text = string.Empty;
            TextBoxName.Text = string.Empty;
            TextBoxPatro.Text = string.Empty;
            TextBoxYear.Text = string.Empty;
            Label1.Text = string.Empty;
        }
    }
}
