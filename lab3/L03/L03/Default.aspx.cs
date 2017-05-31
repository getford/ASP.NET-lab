using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;

namespace L03
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonGet_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:61580/aaa.zvy?param1=1&param2=aaa");
                req.Method = "GET";
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader streamReader = new StreamReader(res.GetResponseStream());
                Label1.Text = streamReader.ReadToEnd();
            }
            catch (WebException ex)
            {
                Label1.Text += "<br/>" + ex.Status + "<br/> " + ex.Message + "<br/>" + ex.TargetSite + "<br/>" + ex.Source;
            }
        }
        protected void ButtonPost_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:61580/aaa.zvy");
            req.Method = "POST";
            String postData = "param1=" + Int32.Parse(TextBox1.Text) + "&param2=" + Int32.Parse(TextBox2.Text);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = byteArray.Length;
            Stream postDataStream = req.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader streamReader = new StreamReader(res.GetResponseStream());
            Label2.Text = streamReader.ReadToEnd();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:61580/aaa.zvy");
            req.Method = "PUT";
            String postData = "param1=111&param2=aaa";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = byteArray.Length;
            Stream postDataStream = req.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader streamReader = new StreamReader(res.GetResponseStream());
            Label3.Text = streamReader.ReadToEnd();
        }

        protected void ButtonSum_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:61580/sum.zvy");
            req.Method = "POST";
            String postData = "param1=" + Int32.Parse(TextBox1.Text) + "&param2=" + Int32.Parse(TextBox2.Text);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = byteArray.Length;
            Stream postDataStream = req.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader streamReader = new StreamReader(res.GetResponseStream());
            TextBoxResult.Text = streamReader.ReadToEnd();
        }
    }
}