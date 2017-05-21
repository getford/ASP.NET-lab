using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/* 1.  Продемонтсрируйте работу элемента UpdatePanel ( Button).
2.	Продемонтсрируйте работу еще трех независимых элементов  UpdatePanel (TextBox, CheckBox, RadioButton).
3.	Для одного из элементов  UpdatePanel продемострируйте обработку в клиенте ошибки, возникшей не стороне сервера
4.	Продемонстрируйте работу триггера UpdatePanel. 
5.	Продемонстрируйте работу двух независимых элементво Timer. 
6.	Для одного из элементов UpdatePanel, задержите время обработки запроса сервером на 15 сек.7.	Продемонстируйте применение элемента UpdateProgress  для  UpdatePanel с серверной задержкой. 
8.	Для элентента UpdateProgress предусмотрите возможность (кнопку) отказа от выполнения асинхронного запроса.*/

namespace L12
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongTimeString();
            System.Threading.Thread.Sleep(3000);
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text == "error")
                throw new ApplicationException("Special custom Error");
            else
                LabelTextBox.Text = DateTime.Now.ToLongTimeString();
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            LabelCheckBox.Text = DateTime.Now.ToLongTimeString();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelRadioButtons.Text = DateTime.Now.ToLongTimeString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            LabelTimer1.Text = DateTime.Now.ToLongTimeString();
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            LabelTimer2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
