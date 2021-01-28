using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.Alıstırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("AD" + "              " + "SOYAD" + "                       " + "TEL NO");
        }
        string[] ad = new string[100];
        string[] soyad = new string[100];
        string[] telNo = new string[100];
        int i = 0;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtAd.Text + "              " + txtSoyad.Text + "                       " + txtTelNo.Text);
            ad[i] = txtAd.Text;
            soyad[i] = txtSoyad.Text;
            telNo[i] = txtTelNo.Text;
            i++;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            /*if (txtAd.Text.Trim().ToLower() == isimler[i].ToLower())
                    {
                        lboxRehber.Items.Add($"{isimler[i]} {soyIsimler[i]} \t {telefonlar[i]}");
                    }*/
            for (int j = 0; j < ad.Length; j++)
            {
                if (txtAraIsim.Text == ad[j])
                {
                    listBox1.SelectedIndex = j+1;
                }
            }
            for (int k = 0; k < soyad.Length; k++)
            {
                if (txtAraSoyad.Text == soyad[k])
                {
                    listBox1.SelectedIndex = k + 1;
                }
            }
            for (int l = 0; l < telNo.Length; l++)
            {
                if (txtAraTelNo.Text == telNo[l])
                {
                    listBox1.SelectedIndex = l + 1;
                }
            }
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    if (txtAraIsim.Text != "")
            //    {
            //        if (listBox1.Items[i].ToString().Contains(txtAraIsim.Text))
            //        {
            //            listBox1.SelectedIndex = i;
            //        } 
            //    }
                
            //    if (txtAraSoyad.Text != "")
            //    {
            //        if (listBox1.Items[i].ToString().Contains(txtAraSoyad.Text))
            //        {
            //            listBox1.SelectedIndex = i;
                        
            //        } 
            //    }

            //    if (txtTelNo.Text != "")
            //    {
            //        if (listBox1.Items[i].ToString().Contains(txtAraTelNo.Text))
            //        {
            //            listBox1.SelectedIndex = i;
            //        } 
            //    }
                
            //}

        }
   }

}

