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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] sehirler = 
        {
            "Uşak",
            "İzmir",
            "İstanbul",
            "Trabzon"
            
        };
        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(sehirler, 1, 2);
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            string[] ornek = new string[4];

            Array.Copy(sehirler, ornek, 3);

            //Array.Copy(sehirler, 3, ornek, 0, 2);
        }
        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sehirler[sehirler.Length-1]);/*Bu son stringi basar.*/
            int index = Array.LastIndexOf(sehirler, "İstanbul");
            /*LastIndexOf bize burada İstanbulun index'ini verir.
             * Eğer o string yoksa -1 döndürür.*/
        }
        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            int index = Array.IndexOf(sehirler, "Uşak");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
