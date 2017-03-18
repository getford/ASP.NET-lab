using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace L03WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:61580/sum.zvy");
            req.Method = "POST";
            String postData = "param1=" + Int32.Parse(textBox1.Text) + "&param2=" + Int32.Parse(textBox2.Text);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = byteArray.Length;
            Stream postDataStream = req.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader streamReader = new StreamReader(res.GetResponseStream());
            textBox3.Text = streamReader.ReadToEnd();
        }
    }
}
