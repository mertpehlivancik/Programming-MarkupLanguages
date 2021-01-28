using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.SwichCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cboxMevsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* <SelectedIndexChanged> event'i comboboxta ki şeçenekler arasından seçim yapıldığı 
             * an devreye girer.Yani comboboxta değişiklik olduğunda çalışır.*/

            ////1.YOL
            //string mevsim = cboxMevsimler.SelectedItem.ToString();
            //MessageBox.Show(mevsim);
            ////2.YOL
            //int index = cboxMevsimler.SelectedIndex;
            //MessageBox.Show(cboxMevsimler.Items[index].ToString());

            string mevsim = cboxMevsimler.SelectedItem.ToString();/*ComboBoxta seçilen item'ı mevsim
                                                                   * isimli string değişkene atadık.
                                                                   * Bu değişken bizim o seçenekleri
                                                                   * kullanmamızda anahtar görevi
                                                                   * görecektir.*/
            switch (mevsim)
            {
                case "kış":
                    MessageBox.Show("aralık\nocak\nsubat");
                    break;
                case "ilkbahar":
                    MessageBox.Show("mart\nnisan\nmayıs");
                    break;
                case "yaz":
                    MessageBox.Show("Haziran\nTemmuz\nAgustos");
                    break;
                case "sonbahar":
                    MessageBox.Show("Eylul\nEkim\nKasım");
                    break;
                default:
                    MessageBox.Show("hatalı seçim yaptınız");
                    break;
            }
            //ikisi de aynı sonuçları verirler.
            if (mevsim == "kış")
            {
                MessageBox.Show("aralık\nocak\nsubat");
            }
            else if(mevsim == "ilkbahar")
            {
                MessageBox.Show("mart\nnisan\nmayıs");
            }
            else if (mevsim == "yaz")
            {
                MessageBox.Show("Haziran\nTemmuz\nAgustos");
            }
            else
            {
                MessageBox.Show("Eylul\nEkim\nKasım");
            }           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboxMevsimler.Items.Add("kış");
            cboxMevsimler.Items.Add("ilkbahar");//ComboBox'a eleman ekleme
            cboxMevsimler.Items.Add("yaz");
            cboxMevsimler.Items.Add("sonbahar");
            /*Eğer comboBox'ın yazılabilirlik özelliğini kapatmak istiyorsak 
             * properties'den dropDownStyle'yi dropdownlist yapmamız gerekir.*/

        }
    }
}
