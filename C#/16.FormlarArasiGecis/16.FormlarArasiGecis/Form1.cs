using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.FormlarArasiGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 Form2 = new Form2();
        private void btnGonder_Click(object sender, EventArgs e)
        {
            Form2.mesaj = txtMesaj.Text;
            //Form2'yi gösterir.
            Form2.Show();
            //İçinde bulunduğu Form'u kapatır.
            this.Hide();
        }
    }
}
