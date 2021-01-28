using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tahmin;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random randi = new Random();
            tahmin = randi.Next(1, 3);       
        }
        int sayac = 1;
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtSayi.Text);

            while (sayi == tahmin)
            {
                MessageBox.Show("bildin");
                break;
            }
            if (sayi != tahmin)
            {
                MessageBox.Show("tekrar");
            }
            //if (sayi == tahmin)
            //{
            //    Text = "TEBRİKLER" + sayac + " kere de bildin";
            //    sayac = 0;
            //}
            //else
            //{
            //    Text = "OLMADI BİR DAHA ";  
            //}
            //sayac++;
        }  

       
    }
}
