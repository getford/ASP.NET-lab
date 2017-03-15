using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_get_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.
                    Create("http://localhost:8080/GET.zvy?param1=1&param2=aaa");
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                Label_get.Text = sr.ReadToEnd();
            }
            catch(WebException ex)
            {
                Label_get.Text += "<br/>" + ex.Status + "<br/> " + ex.Message + "<br/>" + ex.TargetSite + "<br/>" + ex.Source;
            }
        }

        protected void Button_post_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/POST.zvy");

            request.Method = "POST";
            UTF8Encoding encoding = new UTF8Encoding();
            //string data = "param1=" + Int32.Parse(TextBox_X.Text) +
            //    "&param2=" + Int32.Parse(TextBox_Y.Text);
            String data = "parm1=aaa&parm2=bbb";
            byte[] byteArray = encoding.GetBytes(data);

            request.ContentType = "application/x-www-form";
            request.ContentLength = byteArray.Length;

            Stream postDataStream = request.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            Label_result.Text = streamReader.ReadToEnd();
        }

        protected void Button_put_Click(object sender, EventArgs e)
        {

        }

        protected void Button_sum_Click(object sender, EventArgs e)
        {

        }
    }
}