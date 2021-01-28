using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14.OutRefParams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void GeriyeDegerDon(int sayi,out double firlatilanSonuc)
        {
           /*Out return ile aynı işi yapıyor.O zaman aklımızda şu
            * soru işareti oluşuyor.Neden return varken bunu kullanıyoruz?
            * Out sayesinde istersek 2 farklı değeri return edebiliriz.*/
            firlatilanSonuc = Math.Pow(sayi, 2);
        }
        private void btnOut1_Click(object sender, EventArgs e)
        {
            double yakalananSonuc;
            GeriyeDegerDon(12, out yakalananSonuc);
            MessageBox.Show(yakalananSonuc.ToString());
        }
        void Hesapla(int sayi1, int sayi2, out int toplam, out int cikarma, out long carpma, out double bolme, out byte mod)
        {
            toplam = sayi1 + sayi2;
            cikarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;
            mod = (byte)(sayi1 % sayi2);
        }
        private void btnOut2_Click(object sender, EventArgs e)
        {
            int toplam, cikarma;
            long carpma;
            double bolme;
            byte mod;
            Hesapla(8, 3, out toplam, out cikarma, out carpma, out bolme, out mod);
        }
        double FiyatHesapla(params double[] fiyatlar)
        {
            //params dinamik dizi oluşturmaya yarıyor//
            double toplamFiyat = 0;
            foreach (var item in fiyatlar)
            {
                toplamFiyat += item;
            }
            return toplamFiyat;
        }
        private void btnParams_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FiyatHesapla(64.35,35.64).ToString());
        }
        void Arttir(ref int sayi)
        {
            sayi++;
        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            /*buradan ref'i silersek o zaman adresi üzerinden
             * işlem yapmadığı için ekrana 8 yazdırken şimdi
             * adres üzerinde işlem yaptığı için 9 yazdırır.*/
            int number = 8;
            Arttir(ref number);
            MessageBox.Show(number+"");
        }
    }
}
