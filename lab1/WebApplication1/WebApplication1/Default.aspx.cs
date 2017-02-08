using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Hello");
            DropDownList1.Items.Add("World");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            if (TextBox1.Text != "")
            {
                Label1.Text = TextBox1.Text.ToString();
                Label2.Text = "";
            }
            else
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = $"Проверьте корректность ввода.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            if (CheckBox1.Checked == true && DropDownList1.Text.ToString() != "")
            {
                Label1.Text = DropDownList1.Text.ToString();
                Label2.Text = "";
            }
            else
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = $"Проверьте корректность ввода.";
            }
        }
    }
}