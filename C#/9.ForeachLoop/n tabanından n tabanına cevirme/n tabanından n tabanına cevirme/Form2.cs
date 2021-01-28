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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int kacBasamak = 0;
        int bolunen = 1;
        int sayac = 0;
        int degisken = 0;
        int yeniSayi = 0;
        int orginalTaban = 1;
        int aaa = 1;
        private void btnCevir_Click(object sender, EventArgs e)
        {
            kacBasamak = int.Parse(txtOrginalSayi.Text);
            while (kacBasamak > 0)
            {
                kacBasamak = kacBasamak / 10;
                sayac++;
            }
            degisken = int.Parse(txtOrginalSayi.Text);
            orginalTaban = int.Parse(txtOrginalSayiTabani.Text); 
            while (sayac>0)
            {
                degisken = degisken % 10;
                yeniSayi = yeniSayi + (degisken * aaa);
                degisken = degisken / 10;
                aaa = aaa * orginalTaban;
                sayac--;
            }
            MessageBox.Show(yeniSayi+"");

        }
    }
}
