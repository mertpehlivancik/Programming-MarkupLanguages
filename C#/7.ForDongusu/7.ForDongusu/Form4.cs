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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }
        private void btnYanYana_Click(object sender, EventArgs e)
        {
            //Labelın AutoSize'ini False yaparsak label istediğimiz gibi büyüyebilir.
            label1.Text = "";
            for (int i = 0; i < 5; i++)
            {
                label1.Text += "X";
            }
        }
        private void btnAltAlta_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 5; i++)
            {
                label1.Text += "X\n";
            }
        }
        private void btnKare_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    label1.Text += "X  ";
                }
                label1.Text += "\n";
            }
        }
        private void btnIciBosKare_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j > 0 && j < 4) && (i > 0 && i < 4))
                    {
                        label1.Text += "    ";
                    }
                    else
                    {
                        label1.Text += "X  ";
                    }
                }
                label1.Text += "\n";
            }
        }
        private void btnDikUcgen_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    label1.Text += "X  ";
                }
                label1.Text += "\n";
            }
        }
        private void btnCapımTablosu_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int carpim;
                    carpim = i * j;
                    //Alttakiler aynı şeyi yapıyor.
                    //listBox1.Items.Add(i+"x"+j+"="+carpim);
                    listBox1.Items.Add(string.Format("{0} x {1} = {2}", i, j, i * j));
                }
                listBox1.Items.Add("----------------");
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            /*Break komutu ile for döngüsünden direk çıkılır.
             * Örneğin aşağıda döngü i değeri 20'ye geldiği an 
             * 20 değerini de ekleyip(if'in içinde break'tan önce
             * gelen komut sayesinde)durur.*/
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                if (i == 20)
                {
                    //20'yi yazdırıp çıkıyor.
                    listBox1.Items.Add(i);
                    break;
                }
                listBox1.Items.Add(i);
            }
            listBox1.Items.Add(i);/*burada i'nin en son değeri
                                   * 20 de kaldığı için ekrana 
                                   * 20 yazıyor*/
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            //continue bir sonraki iterasyona gönderir.
            for (int i = 0; i < 8; i++)
            {
                int sayi = rnd.Next(1,15);

                if (listBox1.Items.Contains(sayi))
                {
                    continue;
                    /*Continue direk bir sonraki iterasyana
                     * gönderdiği için aşağıdaki i'yi azaltma 
                     * işlemi yapamayız.*/
                    i--;/*Sayı aynı geldiğinde işlemi 1
                         * azaltıp farklı gelene kadar 
                         * işlemi yaptırıyoruz.Böylece 8
                         * farklı sayı yazdırabiliriz*/
                }
                else
                { 
                  /*Eğer sayı farklıysa ekleme yapıyor.*/
                  listBox1.Items.Add(sayi);    
                }
            }
        }
    }
}
