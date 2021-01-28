using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            long gelenDeger = long.Parse(txtDeger.Text);
            //long gelenDeger = Convert.ToInt64(txtDeger.Text);
            /*Burada eğer 9223372036854775807'den büyük bir değer textBoxa girersek 
             * long değerinin üst sınırını aştığımızdan dolayı program hata verir ama
             * biz bu hata ile programın duraksamasını istemiyorsak try-catch bloğunu 
             * kullanmamız gerekir.*/
            MessageBox.Show("Tebrikler, Iphone 8s plus kazandınız!");
        }

        private void btnKontrolluOnay_Click(object sender, EventArgs e)
        {
            try
            {
                //Hata riski olan kodların yazıldığı alan
               long gelenDeger = long.Parse(txtDeger.Text);
               //long gelenDeger = Convert.ToInt64(txtDeger.Text);
               MessageBox.Show("Tebrikler, Iphone 8s plus kazandınız!");
            }
            catch (Exception hata)
            {
                //Hatalı işlem yapıldığına çalışan kod
                //MessageBox.Show("Yanllış değer girdiniz lütfen sayı giriniz");
                MessageBox.Show(hata.Message);//hata mesajını bilgisayardan aldık.
            }
            MessageBox.Show("Devam ediyorum"); /*Eğer 92233720368547758072'den büyük bir değer
                                               * girmiş olsak bile program hata vermez ve mbox
                                                * <Devam ediyorum>'u ekrana yazdırır.Try-Catch
                                                * kullanmasak program hata verip duracaktı*/
        }

        private void btnFinalKontrollu_Click(object sender, EventArgs e)
        {
            try
            {
                long gelenDeger = Convert.ToInt64(txtDeger.Text);
                MessageBox.Show("Tebrikler, Iphone 8s plus kazandınız!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally//Kod bloğunda her zaman yapılacak işlemler finally'in içine yazılır.
            {
                MessageBox.Show("Finally kod bloğu programda hataya rastlansada rastlanmasada uygulanır");
            }
        }      
    }
}
