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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBirdenBine_Click(object sender, EventArgs e)
        {
            //1'er 1'er arttırma
            for (int i = 0; i < 1000; i++)// (i++)<----eşit---->(i=i+1)
            {
                listBox1.Items.Add(i);
            }
            //2'er 2'er arttırma
            for (int i = 0; i < 1000; i=i+2) // (i = i +2 ) <--- eşit ---> (i += 2)
            {
                listBox1.Items.Add(i);
            }
            
            //BONUS///
            int a = 5;
            int b = a++;//a = a + 1; önce ata sonra arttır
            int c = ++a;// önce arttır sonra ata
            //a = 7,b = 5;c = 7;
        }

        private void btnBindenBire_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i > 0; i--)
            {
                listBox1.Items.Add(i);
            }
           
        }

        private void btnAdanZye_Click(object sender, EventArgs e)
        {
            char a = 'B';//Ascii code = 66
            char a2 = 'b';//Ascii code = 98
            MessageBox.Show(Convert.ToInt32(a) + "-" + Convert.ToInt32(a2));
            //MessageBox'ta ascii codeleri yazıyor.
            for (char c = 'A' ; c <= 'Z'; c++)
            {
                //A'dan Z'ye kadar olan büyük harfleri listbox'a ekler.
                //listBox1.Items.Add(c);
                listBox1.Items.Add(c + " - " + Convert.ToInt32(c));
            }
        }
        int toplam=0;
        private void btnGauss_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                toplam = toplam + i;
                //toplam += i;
            }
            lbltoplam.Text = toplam.ToString();
        }
    }
}
