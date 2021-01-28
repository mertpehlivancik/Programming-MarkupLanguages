using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*Dizi Oluşturma*/
            int[] dizi = new int[3];
            dizi[2] = 5;
            dizi[1] = 4;
            dizi[0] = 3;

            string[] sehirler = new string[4]
            {
                "izmir",
                "istanbul",
                "uşak",
                "aydın"
            };
            char[] karakterler = { 'a', 'b', 'c', 'd' };

            int[] sayilar;
            sayilar = new int[1];
            sayilar[0] = 1;
        }
    }
}
