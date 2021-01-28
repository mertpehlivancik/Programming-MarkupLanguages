using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeachLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Öğrenciler";//Formun başlığını değiştirdik.          
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string[] ogrenciler = { "Mert", "Mehmet", "Ahmet", "Salih" };
            foreach (string student in ogrenciler)
            {
                lstBoxOgrenciler.Items.Add(student);/*öğrenciler dizisindeki her 
                                                     * öğrenciyi lstbox'a ekler.
                                                     * Tüm öğrenciler string tipin-
                                                     * dedir.Burada student yerine
                                                     * herhangi bir değişken yaza-
                                                     * bilirdik.Onun ne olduğunun 
                                                     * önemi yoktur.*/
            }
        }
    }
}
