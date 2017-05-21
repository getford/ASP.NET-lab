using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace WFHost
{
    public partial class Form1 : Form
    {
        ServiceHost serviceHost;
        public Form1()
        {
            InitializeComponent();
            serviceHost = new ServiceHost(typeof(WCFDLL.Service1));
            serviceHost.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
