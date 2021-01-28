using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Params
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Metotlarımızı kulllanırken, metot özeti ve kullanımı hakkında bilgi
         * vermek amacıyla oluşturulan yapıdır. Tooltip’de metot hakkında bilgiler
         * göstermek için kullanılmaktadır. Metodun bir üst satırına yan yana ‘///’ 
         * yazıldığında oluşmaktadır*/

        /// <summary>
        /// Bu method içerisine sayı dizisi verildiğinde 
        /// dizinin elemanları toplamını bulmaya yarar.
        /// </summary>
        /// <param name="sayilar">Sayı dizini giriniz</param>
        /// <returns></returns>
        int Topla(params int[] sayilar)
        {
          /*Metotlarımız içerisine göndereceğimiz parametrelerde 
           * aynı tipte olmak kaydıyla göndereceğimiz parametre 
           * sayısını bilmiyorsak params parametresini kullanabiliriz.*/ 
             
            int toplamSonuc = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplamSonuc += sayilar[i];
            }
            return toplamSonuc;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            //int toplam = Topla(1, 2, 3, 4, 5); 

            int[] sayilarin = { 1, 2, 3, 4, 5 };           
            int toplam = Topla(sayilarin);
            //Yuk. ikisi de aynı sonucu veriyor.
            MessageBox.Show("Toplam : "+toplam);
        }

        /*Method Overloading
        void deneme()
        {

        }
        void deneme(int a)
        {

        }
        void deneme(string b)
        {

        }
         */
    }
}
