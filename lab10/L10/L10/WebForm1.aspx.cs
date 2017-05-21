using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace L10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Application["y"] != null)
                TextBoxY.Text = Application["y"].ToString();
            
            HttpCookie cookie = Request.Cookies["xxx"];
            if (cookie != null )
                TextBoxX.Text = cookie.Value;
        }

        protected void ButtonSavetoApplication_Click(object sender, EventArgs e)
        {
            Application["y"] = TextBoxY.Text;
        }

        protected void ButtonSavetoCookie_Click(object sender, EventArgs e)
        {
            Response.Cookies.Add(new HttpCookie("xxx",TextBoxX.Text));
        }
    }
}