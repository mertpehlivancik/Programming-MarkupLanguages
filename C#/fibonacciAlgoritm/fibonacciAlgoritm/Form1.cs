using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacciAlgoritm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region degiskenler
        int sayac = 0;
        int sayi1 = 1;
        int sayi2 = 1;
        int degis;
        int inci = 2;
        int hata = 3;
        int click = 0;
        int timer = 30;
        int hataSayaci = 1;
        #endregion
        private void btnFindFibonacci_Click(object sender, EventArgs e)
        {
        #region Fibonacci
            if (click > 0)
            {
                listBox1.Items.Clear();
                sayac = 0;
                sayi1 = 1;
                sayi2 = 1;
                degis = 0;
                inci = 2;
            }
            try
            {
                listBox1.Items.Add("1.sayi = " + sayi1.ToString());
                sayac = int.Parse(txtFibonacci.Text);
                while (sayac > 0)
                {
                    if (sayac == 1)
                    {
                        MessageBox.Show(txtFibonacci.Text + ". sayi =" + sayi1.ToString());
                        break;
                    }
                    listBox1.Items.Add(inci + ". sayi = " + sayi2.ToString());
                    degis = sayi1 + sayi2;
                    sayi1 = sayi2;
                    sayi2 = degis;
                    sayac--;
                    inci++;
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                MessageBox.Show(ex.Message);
                hata = hata - 1;
                MessageBox.Show("Kalan Kullanım Hakkınız : " + hata);
                if (hata == 0)
                {
                    MessageBox.Show("Programa erişiminiz engellendi.");
                    btnFindFibonacci.Enabled = false;
                    btnFindFibonacci.BackColor = Color.Red;
                    timer1.Enabled = true;  
                }
            }
            click++;
            #endregion
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            btnFindFibonacci.Text = timer.ToString();
            if (timer == 0)
            {
                timer1.Enabled = false;
                btnFindFibonacci.Enabled = true;
                btnFindFibonacci.Text = "Find";
                btnFindFibonacci.BackColor = Color.SeaShell;
                hata = 3;
                /*Altaki kodların amacı kullanıcı 3 hakkını 
                 * tamamladıktan sonra bir daha 3 hata yaparsa
                 * programı kullanmak için daha uzun süre bek-
                 * lemesini sağlamaktır.*/
                timer = 60 * hataSayaci;
                hataSayaci = hataSayaci * 2;
            }
        }
    }     
}

