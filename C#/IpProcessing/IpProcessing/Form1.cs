using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IpProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtComputerName.Text = "Computer: " + Dns.GetHostName();//Write computer name to textbox 
            Console.Beep();//produce sound during pressing the key
            foreach (IPAddress x in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                txtIpAddress.Text = "IP Address: " + x;
            }
        }
    }
}
