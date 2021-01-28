using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_tabanından_n_tabanına_cevirme
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
        int sonuc = 0;
        int basamak = 1;
        int sayi = 0;
        int cevirilecekTaban=0;
        int orginalSayiTabani = 0;
        int kacBasamak=0;
        int bolunen = 1;
        int sayac = 1;
        int yeniSayi = 0;
        int degisken = 0;
        private void btnCevir_Click(object sender, EventArgs e)
        {
            try
            {
                sayi = int.Parse(txtOrginalSayi.Text);
                orginalSayiTabani = int.Parse(txtOrginalSayiTabani.Text);
                kacBasamak = int.Parse(txtOrginalSayi.Text);
                while (true)
                {
                    kacBasamak = kacBasamak / bolunen;
                    sayac++;
                    bolunen = bolunen * 10;
                    if (kacBasamak < 10)
                    {
                        break;
                    }
                }
                MessageBox.Show(sayac+"");
                sayi = int.Parse(txtOrginalSayi.Text);

                while (sayac > 0)
                {
                    degisken = sayi;
                    degisken = degisken % 10;
                    sayi = sayi / 10;
                    yeniSayi = yeniSayi + (degisken * basamak);
                    basamak = basamak * orginalSayiTabani;
                    sayac--;
                }
                MessageBox.Show(yeniSayi + "");

                cevirilecekTaban = int.Parse(txtCevirTaban.Text);
                sayi = int.Parse(txtOrginalSayi.Text);
                while (sayi > 0)
                {

                    sonuc = ((sayi % cevirilecekTaban) * basamak) + sonuc;
                    sayi = sayi / cevirilecekTaban;
                    basamak = basamak * 10;
                }
                lblSonuc.Text = sonuc.ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
