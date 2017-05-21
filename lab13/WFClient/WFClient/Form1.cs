using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client();
            client.Open();
            string s = client.GetData(111);
            ServiceReference1.CompositeType ct = new ServiceReference1.CompositeType();
            ct.BoolValue = true;
            ct.StringValue = "string";
            ServiceReference1.CompositeType rc = client.GetDataUsingDataContract(ct);
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            textBoxSum.Text = client.Sum(decimal.ToInt32(numericUpDownSum1.Value), decimal.ToInt32(numericUpDownSum2.Value)).ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBoxSub.Text = client.Sub(decimal.ToInt32(numericUpDownSub1.Value), decimal.ToInt32(numericUpDownSub2.Value)).ToString();
        }

        private void buttonConcat_Click(object sender, EventArgs e)
        {
            textBoxConcat.Text = client.Concat(textBoxConcat1.Text, textBoxConcat2.Text);
        }
    }
}
