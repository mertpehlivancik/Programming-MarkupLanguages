using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numbers = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            numbers.Add(5);
            numbers.AddRange(new List<int> { 3, 8, 9 });
            numbers.AddRange(new int[] { 45, 55, 65 });
            ListBoxVeriEklemeInt(numbers);
            yeniList = numbers;

        }
        void ListBoxVeriEklemeInt(List<int> gelenList)
        {
            listBox1.Items.Clear();
            if (gelenList.Count != 0)
            {
                foreach (var item in gelenList)
                {
                    listBox1.Items.Add(item);
                }   
            }
            else
            {
                listBox1.Items.Add("Veri Bulunamadı!");
            }         
        }    
        private void btnListCreate_Click(object sender, EventArgs e)
        {
            ListBoxVeriEklemeInt(numbers);
            yeniList = numbers;
        }
        List<int> takimlarinKurulusYillari = new List<int>();
        private void btnYillariEkle_Click(object sender, EventArgs e)
        {
            takimlarinKurulusYillari = new List<int>();
            takimlarinKurulusYillari.AddRange(new int[] { 1995, 1990, 1959, 1881, 2000 });
            ListBoxVeriEklemeInt(takimlarinKurulusYillari);
            yeniList = takimlarinKurulusYillari;
        }
        List<int> yeniList = new List<int>();
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                int index = yeniList.IndexOf(int.Parse(txtSearch.Text));
                Text = index.ToString();

                //if (index > -1)
                //{
                //    ListBoxVeriEklemeInt(new List<int>() { yeniList[index] });
                //}
            }
            else
            {
                ListBoxVeriEklemeInt(yeniList);     
            } 
        }//burayı hocandan bakıp yaz.
        List<int> Search(string text)
        {
           List<int> yeniListSearch
        }
    }
}
