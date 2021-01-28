using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnToplama_Click(object sender, EventArgs e)
        {
            int sayi1 = 38;
            int sayi2 = 83;
            int toplam = sayi1 + sayi2;
            MessageBox.Show(toplam + "");//string'e çevirmenin en kısa yolu onu boş bir string ile birleştirmektir.
            //MessageBox.Show(toplam.ToString());
            MessageBox.Show("toplam : " + toplam); //yukarıda toplamı int stringe çevirdik.Fakat aşağıda çevirmediğimiz halde onu
                                                   //string gibi algıladı.Çünkü burada string ile birleştirme yaprığımızdan direk                      çevirdi.
            MessageBox.Show("toplam : " + (sayi1 + sayi2));//burada iki sayıyı topladık
            MessageBox.Show("toplam : " + sayi1 + sayi2);//burada da iki sayıyı yan yana yazdık.                                          
        }
        private void btnCikarma_Click(object sender, EventArgs e)
        {
            int sayi1 = 93;
            int sayi2 = 39;

            int fark = sayi1 - sayi2;
            MessageBox.Show("Fark :" +fark);
            MessageBox.Show(fark.ToString());
        }
        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sayi1 = 90;
            int sayi2 = 10;
            int carpim = sayi1 * sayi2;

            MessageBox.Show("Carpim :" +carpim);
        }
        private void btnBolme_Click(object sender, EventArgs e)
        {
            float sayi1 = 90;
            float sayi2 = 4;

            float bolum = sayi1 / sayi2;
            MessageBox.Show("bolum : " + bolum);
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            int sayi1 = 15;
            int sayi2 = 4;
            int mod = sayi1 % sayi2;
            MessageBox.Show("Mod = " + mod);
            //Bişeyi eklerken <control> + <.> yaparsak onun için gerekli kütüphaneyi yazar.Debug için ek kütüphane gereklidir.

            Debug.WriteLine("Mod = {0}", mod);
            Debug.WriteLine("{0} mod {1} = {2}",sayi1 , sayi2 , mod);// debug kullanırsak sonuç output ekranında çıkar.      
        }
        private void btnArttırAzalt_Click(object sender, EventArgs e)
        {
            int sayi = 8;
            sayi = sayi + 1;//sayi = sayi +1 -----> EŞİTTİR <-------- sayi(9 oldu) <---atamaIslemi---< 8 +(bildiğimiz toplama) 1
            sayi++;

            MessageBox.Show(sayi.ToString());

            sayi = 84;
            sayi--;//sayi = sayi - 1;
            MessageBox.Show(sayi.ToString());
            Debug.WriteLine(sayi.ToString());
        }
    }
}
