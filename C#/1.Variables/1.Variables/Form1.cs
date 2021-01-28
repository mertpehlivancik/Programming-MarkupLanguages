using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Variables
{
    public partial class Form1 : Form
    {
        // Değişkenler, verileri kaydetttiğimiz alanlardır.
        //Bu değişkenler RAM(Random Access Memory)'de tutulur.
        /*Eğer değişkenleri kullanmazsak Visual Studio da değişkenin altında
         *yeşil çizgi oluşur. 
         *Form1'in içinde bir variable tanımlarsak bu local variable olacağı için Form1 dışında kullanılamaz,
         *kullanmamız için onu global olarak tanımlamamız gereklidir.
         */
        byte sayi; // 0-255 arasında bir değer ataması yapılabilinir
        string metin; // metinsel ifadeler tutulur
        public Form1()
        {
            InitializeComponent();//pass the code fastly putting F7
            sayi = 5;
            metin = "2017 yılındayız";

            byte number;
            sbyte number2; //-128 ile 127 arasında bir değer alır.
            
            short number3;//sağ tıklayıp <go to definition> a basarsak short'un içine girip değer aralıklarını okuyabiliriz
            
            ushort number4;//<go to definition> --------> F12
            int number5;
            uint number6;
            
            long number7;
            ulong number8;
            
            float kesirli; // virgülden sonra 7 basamak duyarlıdır.
            double kesirli2;//virgülden sonra 13-14 basamak duyarlıdır.
            decimal kesirli3;//Virgülden sonra 28 basamak duyarlıdır.

            string isim = "Mert Pehlivancık";
            string harf = "G";
            char m = 'B';

            bool bugunTatilMi = false;
            bool bugunDersVarMi = true;
            bool result = 10 > 2;
            //MessageBox.Show(bugunDersVarMi.ToString());//bunun sonucuna true atadığımız için mb'de true yazar.
            //MessageBox.Show(result.ToString());//bunun sonucunda  10 büyüktür 2 olduğu için mb'de true(doğru) yazar. 
            var deger = "ahmet";
            var deger1 = 5;//bu atadığımız değerin tipine dönüşen bir değişken tipidir.
            var durum = false;
        }

        private void btnClick_Click(object sender, EventArgs e)
        { 
            MessageBox.Show(sayi.ToString());//yukarıda tanımladığımız sayıyı bastırır.
            sayi = 10;//sayının değeri 10 oldu.
            MessageBox.Show(sayi.ToString());//Yeni sayı değerini bastı.
            MessageBox.Show(metin);

            /*Burada bir kere click yaptıktan sonra 2. clickte click döngüsünden çıkmadığı için sayi 2 kere 
             * 10 olarak basılır.
             */
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;//textbox a yazılan herşey form başlığına da yazılır.
        }
        private void btnDateTime_Click(object sender, EventArgs e)
        {
            DateTime zaman = new DateTime();
            zaman = DateTime.Now;//şuanki zamanı zaman değişkenine atadı.
            MessageBox.Show(zaman.ToString());
        }
    }
}
