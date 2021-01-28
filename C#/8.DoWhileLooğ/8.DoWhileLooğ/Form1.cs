using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.DoWhileLooğ
{
    public partial class Form1 : Form
    {
        /*Do-While while'nin tam tersi çalışır*/
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i < 100)
            {
                /*bu kod çalışmaz.Çünkü koşul
                 * sağlanmadı.*/
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            do
            {
                /*Bu kod 1 kere çalışır sonra
                 * kontrol edip döngüden çıkar.
                 * Yani do-while da önce işlem
                 * yapılır sonra kontrol edilir.*/
                listBox1.Items.Add(i);
                i++;
            } while (i<100);
        }
    }
}
