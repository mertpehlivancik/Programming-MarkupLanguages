using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.ForDongusu
{
    public partial class Form2 : Form
    {
        /*Program normalde başlangıçta Form1'den başlıyor.
         * Form2'den başlamak için program.cs'den 
         * Application.Run(new Form1()); yazan yeri 2 yapa-
         * lım ki program Form2'den başlasın.*/      
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "TÜRKİYE";          
        }
        string[] takimlar = { "Fenerbahçe", "Galatasaray", "Beşiktaş", "TrabzonSpor" };
        private void btnTakimlar_Click(object sender, EventArgs e)
        {                  
            //MessageBox.Show(takimlar[0]);
            for (int i = 0; i < takimlar.Length; i++)
            {
                lstBoxTakimlar.Items.Add(takimlar[i]); //Takimlari lstBox'a ekleme
            }
            // Listbox boyutunu form'un text'ine atar.
            Text = lstBoxTakimlar.Items.Count.ToString();
            //lstBoxTakimlar.SelectedIndex = 0; 
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstBoxTakimlar.Items.Clear();
            Text = lstBoxTakimlar.Items.Count.ToString();
        }

        private void btnGez_Click(object sender, EventArgs e)
        {   /*Sırasıyla liste elemanlarını yukarıdan aşağıya gezer*/        
            if (lstBoxTakimlar.Items.Count != 0)
            {
                for (int i = 0; i < lstBoxTakimlar.Items.Count; i++)
                {
                    lstBoxTakimlar.SelectedIndex = i;
                    Thread.Sleep(100);/*Kodu saniyenin 1/10'u kadar zaman
                                       * duraktır.*/
                }
            }
            else
            {
                MessageBox.Show("Liste Boş");
            }
        }

        private void lstBoxTakimlar_Click(object sender, EventArgs e)
        {                 
            int index = lstBoxTakimlar.SelectedIndex;
            /*Boş satırın indexi -1'dir.Aşağıdaki kod derleyicinin boş 
             * satırları silmeye çalışıp hata vermesini engeller.*/            
            if (index != -1) 
            {
                lstBoxTakimlar.Items.RemoveAt(index);
            }
            //listbox boyunutunu form'un text'ine atar.
            Text = lstBoxTakimlar.Items.Count.ToString();
        }
        private void btnSayilar_Click(object sender, EventArgs e)
        {
            int cift = 0;
            int tek = 0;
            int[] sayilar = { 38, 45, 56, 67 ,2 };
            for (int i = 0; i <sayilar.Length; i++)
            {
                if (sayilar[i]%2 == 0)
                {
                    cift = cift + 1;
                }
                else
                {
                    tek = tek + 1;
                }
            }
            MessageBox.Show("tek adedi: " + tek);
            MessageBox.Show("cift adedi: " + cift);
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random randi = new Random();
            for (int i = 0; i < 10; i++)
            {
                int sayi = randi.Next(1, 11);/*1 ile 11 arası sayı üretir
                                              * 11 dahil değil 1 dahil.*/
                lstBoxTakimlar.Items.Add(sayi);
            }            
        }       
    }
}