using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.ForDongusu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {                    
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();        
            int cift=0;
            int tek = 0;
            Random randi = new Random();
            for (int i = 0; i < 10; i++)
            {
                int sayi = randi.Next(1, 101);/*1 ile 11 arası sayı üretir
                                              * 11 dahil değil 1 dahil.*/
                if (sayi % 2 == 0)
                {
                    cift = cift + 1;
                }
                else
                {
                    tek = tek + 1;
                }
                listBox1.Items.Add(sayi.ToString());
            }           
            MessageBox.Show("tek adedi: " + tek);
            MessageBox.Show("cift adedi: " + cift);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Tıklanılan itemın silinmesini sağlar.if'i yazmamızın
             * sebebi hata mesajı almamaktır.(boşluğun indexi -1'dir)*/
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex != -1)
            {
                listBox1.Items.RemoveAt(selectedIndex);
            }       
        }
        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            //Form da yer alan kontrol sayısını basar
            MessageBox.Show(this.Controls.Count.ToString());
            
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Button)
                {/*Kontol button ise*/
                    if (Controls[i].Text != "TekCiftGöster")
                    {   //Kontrol'ün text'i TekCiftGöster değil ise
                        Controls[i].BackColor = Color.Aquamarine;
                        Controls[i].ForeColor = Color.Bisque; 
                    }                 
                }
                else/*button harici ise*/
                {
                    Controls[i].BackColor = Color.BlanchedAlmond;
                    Controls[i].ForeColor = Color.BurlyWood;
                }
            }
        }
        int toplam = 0;
        private void btnSon_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;

            for (int i = 0; i < metin.Length; i++)
            {/*Try-Catch'in buradaki amacı harf dahi girsek programın 
              * durmadan diğer girilen sayılarla işleme devam etmesidir.*/
                try
                {
                    toplam = toplam + Convert.ToInt32(metin[i].ToString());

                    MessageBox.Show(toplam.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                
            }   
            
        }
       
    }
}
