using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.MathLibray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPi_Click(object sender, EventArgs e)
        {
            Text = Math.PI.ToString();
        }
        private void btnMutlak_Click(object sender, EventArgs e)
        {
            Text = Math.Abs(-45).ToString();
        }
        private void btnFloor_Click(object sender, EventArgs e)
        {
            //Floor 12'ye yuvarlar.
            Text = Math.Floor(12.98).ToString();
        }
        private void btnCeiling_Click(object sender, EventArgs e)
        {
            //Ceiling 13'e yuvarlar.
            Text = Math.Ceiling(12.98).ToString();
        }
        private void btnRound_Click(object sender, EventArgs e)
        {
            /*Noktaden sonra eğer 50'den büyük bir değer varsa
             * 13'e küçük bir değer varsa 12'ye yuvarlar.Floor ve
             * Ceiling'e göre onun kontrolünü yapar.*/
            Text = Math.Round(12.49).ToString();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            Text = Math.Max(45, 46).ToString();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            //Text = Math.Min(45, 46).ToString();
            /*Birden çok sayının minimununu bulmaya yarar.*/
            Text = Math.Min(45, Math.Min(13, Math.Min(2, 1))).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnUst_Click(object sender, EventArgs e)
        {
            int taban = int.Parse(txtTaban.Text);
            int ust = int.Parse(txtUst.Text);
            Text = Math.Pow(taban, ust).ToString();

            //long sonuc = taban;

            //for (int i = 0; i < ust-1; i++)
            //{
            //    sonuc *= taban; // 3 * 3 * 3 * 3 
            //}
            //Text = sonuc.ToString();
        }
        
    }
}
