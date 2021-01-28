using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.ColorBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color RastgeleRenk()
        {
            return Color.FromArgb();
        }
        Button[] buttonDizi = new Button[10];
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < buttonDizi.Length; i++)
            {
                buttonDizi[i] = new Button();
                buttonDizi[i].Width = 40;
                buttonDizi[i].Height = 40;
                buttonDizi[i].Left = buttonDizi[i].Width * i;
                buttonDizi[i].Top = 10;

                this.Controls.Add(buttonDizi[i]);
            }
        }
    }
}
