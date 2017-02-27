using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        public String Mark;

        protected void Page_Load(object sender, EventArgs e)
        {
            Mark = (String)this.Session["x11"];
        }

        protected void Button_get_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://vova-pc:8080/yyy.ndy");
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());
                Response.Write(streamReader.ReadToEnd());
            }
            catch (WebException exception)
            {
                Response.Write(exception.Status);
                Response.Write("<br/>" + exception.Message);
                Response.Write("<br/>" + exception.TargetSite);
                Response.Write("<br/>" + exception.Source);
            }
        }

        protected void Button_post_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://vova-pc:8080/yyy.ndy");
            request.Method = "POST";
            request.MaximumResponseHeadersLength = 100;
            request.ContentLength = 0;      // !!!!!!!!!!!!!!!1111
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            Response.Write(streamReader.ReadToEnd());
        }

        protected void Button_options_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://vova-pc:8080/yyy.ndy");
            request.Method = "OPTIONS";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            Response.Write(streamReader.ReadToEnd());
        }
    }
}