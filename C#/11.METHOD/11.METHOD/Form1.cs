using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.METHOD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            listBox1.Items.Add(ad + "\t" + soyad);
            temizle();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
