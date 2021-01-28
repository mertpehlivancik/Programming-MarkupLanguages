using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.ConvertClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bu kısma yazdığımız kodlar form yüklenmeden çalışır//

            int sayi = 38;
            string mesaj = sayi.ToString();
            sayi++;
            MessageBox.Show("Sayi: " + sayi);
            MessageBox.Show("Mesaj: " + mesaj);//ilk 39 sonra 38 yazıyor.
            //Sayının string değerini mesaja atadık.Sayı++; sayının int değerini arttırıyor.String değerinde değişiklik yok.
            MessageBox.Show(sayi.ToString());
            MessageBox.Show(mesaj);


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string cevrilecekDeger = txtSayi.Text;

            MessageBox.Show("Int : " + Convert.ToInt32(cevrilecekDeger));
            MessageBox.Show("Byte : " + Convert.ToByte(cevrilecekDeger));//Go to definition'a(F12) gidilerek değer aralıklarına bakılabilinir
            MessageBox.Show("Float : " + Convert.ToSingle(cevrilecekDeger));

            bool a = true;
            MessageBox.Show(a.ToString());// Bunun sonucunda ekrana true yazdırılır.
        }
    }
}
