using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace _6._5_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*TextBox'ın TextAlign isimli bir özelliği vardır.Bu özelliği 
             * properties'den değiştirerek text'in konumunu değiştirebiliriz.*/
            cboxHesapSecim.Items.Add("carpma");
            cboxHesapSecim.Items.Add("bolme");
            cboxHesapSecim.Items.Add("cıkarma");
            cboxHesapSecim.Items.Add("toplama");
        }
        private void cboxHesapSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double sayi1 = Convert.ToDouble(txtSayi1.Text);
                double sayi2 = Convert.ToDouble(txtSayi2.Text);
                string islem = cboxHesapSecim.SelectedItem.ToString();
                switch (islem)
                {
                    case "toplama":
                        MessageBox.Show((sayi1 + sayi2).ToString());
                        break;
                    case "carpma":
                        MessageBox.Show((sayi1 * sayi2).ToString());
                        break;
                    case "bolme":
                        MessageBox.Show((sayi1 / sayi2).ToString());
                        break;
                    case "cıkarma":
                        MessageBox.Show((sayi1 - sayi2).ToString());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
