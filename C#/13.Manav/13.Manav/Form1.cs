using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Manav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] urunFiyat = new double[20];
        double[] turuncgillerFiyat = new double[3];
        double[] baklagillerFiyat = new double[3];
        private void Form1_Load(object sender, EventArgs e)
        {
            cboxUrunler.Items.Add("baklagiller");
            cboxUrunler.Items.Add("turuncgiller");
        }
        void BaklagilListele()
        {
            listboxUrunler.Items.Clear();
            listboxUrunler.Items.Add("nohut\t\t5$(kg)");
            listboxUrunler.Items.Add("bezelye\t\t3$(kg)");
            listboxUrunler.Items.Add("fasulye\t\t4$(kg)");
        }
        void TuruncgillerListele()
        {
            listboxUrunler.Items.Clear();
            listboxUrunler.Items.Add("portakal\t\t3$(kg)");
            listboxUrunler.Items.Add("mandalina\t\t4$(kg)");
            listboxUrunler.Items.Add("limon\t\t8$(kg)");
        }

        private void cboxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboxUrunler.SelectedIndex;
            if (index == 0)
            {
                BaklagilListele();
            }
            else if(index == 1)
            {
                TuruncgillerListele();
            }
        }
        int count = 0;
        bool turuncgilMi = false;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urun = listboxUrunler.SelectedItem.ToString();
            double kilo = (double)numKilo.Value;
            int index = listboxUrunler.SelectedIndex;

            if (turuncgilMi == true)//if(cboxUruler.SelectedIndex == 1)
            {                       //Seçili grup turungil ise
                urunFiyat[count] = kilo * turuncgillerFiyat[index];
            }
            else
            {
                urunFiyat[count] = kilo * baklagillerFiyat[index];
            }
            listboxSepet.Items.Add(urun + "\t " + kilo);
            count++;
        }
        double toplam = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            foreach (var item in urunFiyat)
            {
                toplam += item;
            }
            MessageBox.Show("toplam"+toplam );
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            count = 0;
            listboxSepet.Items.Clear();
            listboxUrunler.Items.Clear();
            urunFiyat = new double[20];
            turuncgilMi = false;
        }

        private void listboxSepet_DoubleClick(object sender, EventArgs e)
        {
            int index = listboxSepet.SelectedIndex;
            listboxSepet.Items.RemoveAt(index);
            urunFiyat[index] = 0;
        }
    }
}
