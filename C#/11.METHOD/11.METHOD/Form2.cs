using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.METHOD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region eski
		 //int topla(int sayi1, int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;
        //    return toplam;
        //}
        //private void btnTopla_Click(object sender, EventArgs e)
        //{
        //    int num1 = (int)numSayi1.Value;
        //    int num2 = (int)numSayi2.Value;
        //    int toplam = topla(num1, num2);
        //    MessageBox.Show("toplam:\t"+toplam);
        //}
        //Random rnd = new Random();
        //void tekCift()
        //{
        //    /////MANTIKEN YANLIŞ KULLANIM//////
        //    /*Eğer böyle kullanırsak bunu bir daha başka 
        //     * bir yerde kullanamayız(Sadece txtSayi ' ya özel gibi oldu 
        //     * onun için kullanamayız).Bu da method yapısına terstir.*/           
        //    try
        //    {
        //        if (Convert.ToInt32(txtSayi.Text) % 2 == 0)
        //        {
        //            MessageBox.Show("cift");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Tek");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //string TekCift(int sayi)
        //{/*Burada sayiyi dışarıdan alıyoruz.Dolayısıyla bu
        //  * methodu txtSayi'nin haricinde değerler vererekte
        //  * kullanabiliriz.*/
        //    if (sayi % 2 == 0)
        //    {
        //        return "Cift";
        //    }
        //    else
        //    {
        //        return "Tek";
        //    }
        //}
        //private void btnCiftTek_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(TekCift(int.Parse(txtSayi.Text)));
        //}
        //private void btnRandomSayiTekCift_Click(object sender, EventArgs e)
        //{
            
        //    int sayi = rnd.Next(1, 1000);

        //    if (TekCift(sayi) == "Tek")
        //    {
        //        MessageBox.Show("Kaybettiniz" +sayi);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Kazandiniz" +sayi);
        //    }
        //}
        //void RenkDegistir(string color)
        //{
        //    BackColor = Color.FromName(color);
        //}
        //private void cbRenkler_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    RenkDegistir(cbRenkler.SelectedItem.ToString());
        //}
        //void RenkDegistir()
        //{
        //    /*Tüm renkler kırmızı,yeşil ve mavi renklerinin
        //     * birleşiminden oluşmuştur.Bu renklerin tonları 
        //     * 0 ve 256 arasındaki sayılar(dahil) ile ifade
        //     * edilir.Bunların karışımından diğer renkler türe-
        //     * tilir.*/
        //    int red = rnd.Next(0, 256);
        //    int blue = rnd.Next(0, 256);
        //    int green = rnd.Next(0, 256);
        //    /*FromArgb renk kodlarını alarak renk türetir.*/
        //    BackColor = Color.FromArgb(red, green, blue);
        //    //Üretilen renklerin adlarını text başlığı yaptık.
        //    Text = BackColor.Name.ToString();
        //}      
        //private void btnRandomColor_Click(object sender, EventArgs e)
        //{
        //    //Random olarak arkaplanı değiştiren methodu çağırdık.
        //    RenkDegistir();
        //}
        //Color ArkaPlanRengi()
        //{
        //    return BackColor;
        //}

        //private void btnBackColor_Click(object sender, EventArgs e)
        //{
        //    Color c = ArkaPlanRengi();
        //    MessageBox.Show(c.Name);


        //    System.Diagnostics.Process.Start("https://www.google.com.tr/");
        //    //Yukarıdaki kod google'yi açar.//
        //}
	#endregion

        string MailOlustur(string ad, string soyad)
        {
            /*Substring methodunda başlangıç indexi ve uzunluk verilir.Tek tek karakterler üzerinde
             * işlem yapmak mümkündür.*/
            string degisenSoyad = soyad.Substring(0, 1).ToUpper() + soyad.Substring(1, soyad.Length - 1).ToLower();
            string degisenAd = ad.Substring(0, 1).ToUpper() + ad.Substring(1, ad.Length - 1).ToLower();
            string genelMetin = degisenAd + degisenSoyad;
            return genelMetin;// or degisenAd + degisenSoyad;
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MailOlustur(txtAd.Text.Trim(),txtSoyad.Text.Trim()) + cbMailDomain.SelectedItem.ToString()); 
        }
    }
}
