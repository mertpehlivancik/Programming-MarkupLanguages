using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.IfElseDecisionStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtAdmin.Text.ToLower().Trim() == "admin")//iki değerin aynı olma durumu.ToLower() girilen bütün büyük harfleri küçük harf yapmayı sağlar.Trim() komutu boşlukları yok sayar.admin yazıp boşluk bırakırsak hata vermiyor
            {
                MessageBox.Show("Hoşgeldin Admin");
            }
            else
            {
                MessageBox.Show("Tanıyamadım , Kimsiniz?");
            }
            txtAdmin.Clear();//Butona basıldığında textbox'ın içeriğinin silinmesini sağlar.
            txtAdmin.Focus();//txtAdmin'e odaklanarak imleci oraya yerleştirir.Böylece kutuya basmadan direk yazı yazabiliriz.
        }
        private void txtAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//basılan tuş Enter mı?
            {
                btnAdmin_Click(sender, e);//sender oradaki textBox ı e ise (tamamla burayı)
            }
            else
            {
                this.Text = txtAdmin.Text;//Burada txtAdmin'in textini formun başlığı yapıyor.
            }
        }
        private void btnNot_Click(object sender, EventArgs e)
        {
            /*Burada txt'ye integer haricinde bir değer girersek program normalde hata verip
             * çalışmayı durdurur fakat biz bu kodları try-catch bloğunun içine yazdığımız 
             * için try'da çıkan hata hemen bizim catch bloğuna geçiş yapmamızı sağlar.Catch 
             * bloğunda da hata mesajı verdirip programın çalışmasına devam etmesini sağlarız*/
            try
            {
                int not = Convert.ToInt32(txtAdmin.Text);
                if (not < 0)
                {
                    MessageBox.Show("0 dan küçük değer giremezsiniz");
                }
                else if (not > 100)
                {
                    MessageBox.Show("100 den büyük değer giremezsiniz");
                }
                else
                {
                    MessageBox.Show("Doğru değer girildi."+ not);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Lütfen sadece sayı giriniz");
            }
        }
        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(txtAdmin.Text);

                //KOLAYCA STRINGE CEVİRME YONTEMI   
                //string strSayi = sayi + "";//Herhangi birşeyi string ile toplarsak diğer değer sayi olur.Stringe çevirme.
                //MessageBox.Show(strSayi);//bu iki satır ek bilgidir.

                if (sayi % 2 == 0)// %(yüzde işareti) programda mod(sayının kalanını bulmada işe yarar) almadır.
                {
                    this.Text = sayi + "cift";
                }
                else
                {
                    MessageBox.Show(sayi +" "+ "Tek");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);          
            }          
        }
        private void btnLogin_Click(object sender, EventArgs e)
        { 
            ////Text'i şifreli göstermenin 2 yolu vardır.
            txtSifre.PasswordChar = '?';//şifre karakterini  <?> yapar.
            txtSifre.UseSystemPasswordChar = true;//bunda şifre karakteri default olarak <*> gelir.
                                                   
            if (txtSifre.Text.Length >= 8)//txt'nin uzunluk kontrolü
            {
                //şifre girerken boşluğu da sayıyor.
                MessageBox.Show("Giris Onaylandı");
                txtSifre.BackColor = Color.Green;//txt'nin arkaplan rengini değiştiriyor.
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre girmemiz gerekiyor");
                txtSifre.BackColor = Color.Red;
            }   
        }
        private void txtSifre_Enter(object sender, EventArgs e)//yazmaya başladığımız an devreye girer
        {
            txtSifre.BackColor = Color.Pink;
        }
        private void txtSifre_Leave(object sender, EventArgs e)//textboxtan ayrıldığımız an devreden çıkar.
        {
            txtSifre.BackColor = Color.White;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Bu kod bloğu da txtAdmin_KeyDown ile aynı işi yapar.Ama bu bir kere bastırıyor,diğeri sınırsız.
            if (e.KeyCode == Keys.Enter)
            {
                btnAdmin_Click(sender, e);//sender oradaki textBox ı e ise (tamamla burayı)
            }
            else
            {
                this.Text = txtAdmin.Text;
            }
        }
    }
}
