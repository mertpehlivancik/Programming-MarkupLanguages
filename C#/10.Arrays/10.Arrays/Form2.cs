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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < arabalar.Length; i++)
            {
                //arabaları comboBoxa ekler.
                comboBox1.Items.Add(i);
            }
        }
        string[] arabalar = { "Fiat", "Mazda", "Mercedes", "BMW", "AUDI" };
        private void btnSonEleman_Click(object sender, EventArgs e)
        {
          MessageBox.Show(arabalar[arabalar.Length-1]);//dizinin son elemanı
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = int.Parse(comboBox1.SelectedItem.ToString());
            MessageBox.Show(arabalar[index]);
        }

        private void btnRastgeleElemanGetir_Click(object sender, EventArgs e)
        {
            //ekrana rastgele araba modeli basar.
            Random randi = new Random();
            /*int index = randi.Next(0,10); // 0,1,2,3,4,5,6,7,8,9 */
            int index = randi.Next(0, arabalar.Length);
            MessageBox.Show(arabalar[index]);
        }
        int[] sayilar = { 12, 23, 34, 45, 56 };
        int toplam = 0;
        int i = 0;
        int j = 1;
        private void btnEkleTopla_Click(object sender, EventArgs e)
        {
            if (toplam == 0)
            {
                i = 0;
                j = 1;
            }
            if (i < sayilar.Length)
            {
                listBox1.Items.Add(sayilar[i]);
                toplam = toplam + sayilar[i];
                Text = toplam + "";
                listBox1.SelectedIndex = i;
            }
            else
            {
                /*eklenen sayıları sırasıyla siler
                 * ve toplamdan düşer.*/
                listBox1.Items.RemoveAt(i - j);
                toplam -= sayilar[i - j];
                Text = toplam + "";
                listBox1.SelectedIndex = (i - j) - 1;
                j = j + 2;
            }
            i++; 
            //foreach (int sayi in sayilar)
            //{
            //    listBox1.Items.Add(sayi);
            //    toplam = toplam + sayi;
            //    MessageBox.Show(toplam+"");
            //}
        }   
    }
}
