using System;
using System.Windows.Forms;

namespace L10WF
{
    public partial class Form1 : Form
    {
        ServiceReference1.WebService1SoapClient client;
        public Form1()
        {
            
            InitializeComponent();
            client = new ServiceReference1.WebService1SoapClient();
            int sessionX = 50;
            client.CheckSessionSetX(sessionX);
            if (client.GetX() != sessionX)
                MessageBox.Show("No session");
            textBoxX.Text = Properties.Settings.Default.x.ToString();
            textBoxY.Text = Properties.Settings.Default.y.ToString();
            textBoxResult.Text = Properties.Settings.Default.r.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxResult.Text= (client.Add(int.Parse(textBoxX.Text),int.Parse(textBoxY.Text))).ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = (client.Sub(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text))).ToString();

        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = (client.Mul(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text))).ToString();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.x = int.Parse(textBoxX.Text);
            Properties.Settings.Default.y = int.Parse(textBoxY.Text);
            Properties.Settings.Default.r = int.Parse(textBoxResult.Text);
            Properties.Settings.Default.Save();
        }
    }
}
