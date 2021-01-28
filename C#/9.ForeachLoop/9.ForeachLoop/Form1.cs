using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.ForeachLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sehirler = { "Uşak", "İzmir", "Muğla", "Aydın", "Kütahya" };
        private void btnEkle_Click(object sender, EventArgs e)
        {                                        
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}
            //Bu ikisi aynı işi yapıyor.
            foreach (string str in sehirler)
            {
                listBox1.Items.Add(str);
            }
        }
        int sayac = 0;
        private void btnIkiyeBolunenler_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 123, 34, 56, 7, 23, 445, 67, 98, 22, 23, 66, 132, 24 };
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi.ToString());
                }
                if (sayi % 3 == 0)
                {
                    listBox2.Items.Add(sayi.ToString());
                }
                if (sayi % 2 != 0 && sayi % 3 != 0)
                {
                    listBox3.Items.Add(sayi);
                }
                if (sayi % 6 == 0/*sayi % 2 == 0 && sayi % 3 == 0*/ )
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if(Convert.ToInt32(listBox1.Items[i].ToString()) == sayi)
                        {
                            listBox1.SelectedIndex = i;
                        }
                    }
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        if (Convert.ToInt32(listBox2.Items[i].ToString()) == sayi)
                        {
                            listBox2.SelectedIndex = i; 
                        }
                    }
                    sayac++; 
                }
            }
            MessageBox.Show("Hem ikiye hem üçe bölünebilen sayı sayısı : "+sayac+"");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
