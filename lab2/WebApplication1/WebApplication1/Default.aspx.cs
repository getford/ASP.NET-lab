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
            if(!Page.IsPostBack)
            viewState.Text += $"-Page Load (IsPostBack == false)-";
            else
                viewState.Text += $"-Page Load (IsPostBack == true)-";
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
        }
    }
}