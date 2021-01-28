using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._8_HesapMakinesiYeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    //NumericUpDown'da text değil de value vardır.Value integer döndürür.       
             try
            {
                string islem = comboBox1.SelectedItem.ToString();
                switch (islem)
                {
                    case "toplama":
                        lblSonuc.Text = (numSayi1.Value + numSayi2.Value) + "";
                        break;
                    case "carpma":
                        lblSonuc.Text = (numSayi1.Value * numSayi2.Value) + "";
                        break;
                    case "bolme":
                        lblSonuc.Text = (numSayi1.Value / numSayi2.Value) + "";
                        break;
                    case "cıkarma":
                        lblSonuc.Text = (numSayi1.Value - numSayi2.Value) + "";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("carpma");
            comboBox1.Items.Add("bolme");
            comboBox1.Items.Add("cıkarma");
            comboBox1.Items.Add("toplama");
        }

        private void numSayi1_ValueChanged(object sender, EventArgs e)
        {
            //burada fark edileceği üzere 2 adet referans var.Bu bizim kod bloğumuzun 2 farklı yerde kullanıldığını gösteriyor.
            lblSonuc.Text = numSayi1.Value + numSayi2.Value + "";//bu kod ile valuechanged birleşince her sayi arttırdığımızda toplam değişiyor.
        }
        //textAlign kısmını değiştirdiğimizde numupdown' a yazılan sayının nerede olacağına karar veriyoruz.

        
    }
}
