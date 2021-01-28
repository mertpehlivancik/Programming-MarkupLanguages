using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Degiskenler
        decimal sonuc, degis;
        int hata = 3;
        int[] sayilar = { 0, 0, 0, 0 };
        int toplam = 0;
        #endregion
        #region KeyUret
        void KeyUret()
        {
            #region RandomKeyUretme
            Random randi = new Random();
            for (int i = 0; i < 4; i++)
            {
                sayilar[i] = randi.Next(1, 10);
            }
            foreach (int ss in sayilar)
            {
                if (sayilar[0] == ss)
                {
                    /*işlemin başında '+' gözükmesini engeler*/
                    lblKey.Text = lblKey.Text + "  " + (ss + "");
                }
                else
                {
                    lblKey.Text = lblKey.Text + " + " + (ss + "");
                }
                toplam = toplam + ss;
            }
            #endregion
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Factorial";
        }
        private void btnFactorialCalculation_Click(object sender, EventArgs e)
        {
            #region Factorial
            while (true)
            {
                try
                {
                    if (int.Parse(txtFactorial.Text) > 27)
                    {
                        txtFactorial.Clear();
                        txtFactorial.Focus();
                        MessageBox.Show("Bu program 27 faktöriyelden fazlasını hesaplayamaz");
                        hata--;
                        MessageBox.Show(hata + " kullanım hakkınız kaldı");
                        if (hata == 0)
                        {
                            btnFactorialCalculation.Enabled = false;
                            toplam = 0;
                            KeyUret();
                            lblKey.Visible = true;
                            hata = 3;
                        }
                        break;
                    }
                    if (int.Parse(txtFactorial.Text) < 0)
                    {
                        txtFactorial.Clear();
                        txtFactorial.Focus();
                        MessageBox.Show("Faktöriyel negatif değer alamaz");
                        hata--;
                        MessageBox.Show(hata + " kullanım hakkınız kaldı");
                        if (hata == 0)
                        {
                            btnFactorialCalculation.Enabled = false;
                            toplam = 0;
                            KeyUret();
                            lblKey.Visible = true;
                            hata = 3;
                        }
                        break;
                    }
                    decimal fact = Convert.ToDecimal(txtFactorial.Text);
                    degis = fact - 1;
                    if (fact == 0 || fact == 1)
                    {
                        sonuc = 1;
                        MessageBox.Show(sonuc.ToString());
                    }
                    else
                    {
                        while (degis > 0)
                        {
                            fact = fact * degis;
                            degis--;
                        }
                        MessageBox.Show(fact.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    hata--;
                    MessageBox.Show(hata + " kullanım hakkınız kaldı");
                }
                if (hata == 0)
                {
                    btnFactorialCalculation.Enabled = false;
                    toplam = 0;
                    KeyUret();
                    lblKey.Visible = true;
                    hata = 3;
                }
                break;
            }
            #endregion  
        }
        private void txtFactorial_TextChanged(object sender, EventArgs e)
        {
            if (txtFactorial.Text == toplam.ToString())
            {
                btnFactorialCalculation.Enabled = true;
                lblKey.Visible = false;
                lblKey.Text = "I am not robot"+" ";
            }
        }      
    } 
}
