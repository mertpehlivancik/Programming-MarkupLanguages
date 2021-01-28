using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methodlar
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
        //void ikiSayiyiTopla()
        //{  /* Metodun geriye dönüş tipi void olarak işaretlendiğinden 
        //    * bizden bir geriye dönüş beklemedi*/
        //    decimal sayi1 = numSayi1.Value;
        //    decimal sayi2 = numSayi2.Value;
        //    /*NumericUpDown decimal değer döndürdüğü için ondan aldığımız
        //     * değeri yine decimal bir sayıya atayabiliriz.*/
        //    MessageBox.Show("Toplam : "+(sayi1+sayi2));

        void ikiSayiyiTopla2(decimal x, decimal y)
        {
            decimal sonuc = x + y;
            MessageBox.Show("Toplam: " + sonuc);
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            decimal sayi1 = numSayi1.Value;
            decimal sayi2 = numSayi2.Value;
            ikiSayiyiTopla2(sayi1, sayi2);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string bilgi = BilgiGoster();/*Metodumuzu çağırdık. Bize string 
                                          * bir değer döndürdüğü için dönen 
                                          * değeri string bir değişkene aktardık.*/ 
            MessageBox.Show(bilgi);//Dönen bilgiyi ekranda gösterdik. 
        }
        string BilgiGoster()
        {
            string sayi = numSayi1.Value.ToString();
            string sayi2 = numSayi2.Value.ToString();
            return sayi;
        }
        int yas;
        string showInformation(string adi, string soyadi, int dTarih)
        {   
            //Şimdiki tarihten doğum yılını çıkarıyoruz ve yaşı elde ediyoruz.      
            yas = Convert.ToInt32(DateTime.Now.Year - dTarih);  
            //String format ile bilgileri gösteriyoruz.            
            return string.Format("Sayın {0} {1}, Yaşınız : {2}", adi, soyadi.ToUpper(), yas);
            //ToUpper() metodu, yazının tamamını büyük harfe çevirir. 
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            string bilgi = showInformation(txtAdi.Text, txtSoyadi.Text,Convert.ToInt32(txtDogumTarihi.Text));
            /*Metodumuzu çağırdık. Bize string bir değer döndürdüğü için dönen değeri string bir değişkene 
             * aktardık. İstediği parametrelere SIRASIYLA ad, soyad ve doğum yılı bilgilerini gönderdik. */
            MessageBox.Show(bilgi);
        }
    }
}

