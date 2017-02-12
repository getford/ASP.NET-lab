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
        protected void Page_Init(object sender, EventArgs e)
        {
            viewState.Text = "";
            viewState.Text += $"-Page Init-";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            viewState.Text += $"-Page Load-";
            /*
            if (!Page.IsPostBack)
                viewState.Text += $"-Page Load (IsPostBack == false)-";
            else
                viewState.Text += $"-Page Load (IsPostBack == true)-";
        */
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            viewState.Text += $"-Page Prerender-";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            viewState.Text += $"-Page Unload-";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            viewState.Text += $"-Button Click-";
            Label_len.Text = $"[Длина viewstate: {viewState.Text.Length}. Длина текста в textbox: {TextBox1.Text.Length}]";
        }

        protected void Button_sys_info(object sender, EventArgs e)
        {
            viewState.Text += $"-Button Sys Info Click-";

            this.Response.Write($"<br> Символическое имя машины: {Environment.MachineName}");
            this.Response.Write($"<br> Версия ОС: {Environment.OSVersion}");
            this.Response.Write($"<br> Объем памяти: {Environment.WorkingSet}");
            this.Response.Write($"<br> Версия ASP.NET: {Environment.Version}");
            /*
             * this.Response.Write($"");
            this.Response.Write($"");
            this.Response.Write($"");
            this.Response.Write($"");
            this.Response.Write($"");
            this.Response.Write($"");
            */
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            viewState.Text += $"-CheckBox-";
        }
    }
}