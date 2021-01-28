using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TernaryIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMutlak_Click(object sender, EventArgs e)
        {
            /*TernaryIf conditionda soru işaretinin soluna koşul yazılır.Eğer koşul sağlanırsa soru işaretinin sağına 
             * yapılacak işlem yazılır , koşul sağlanmazsa <:> dan sonraki işleme geçer.*/
            int sayi = int.Parse(txtSayi.Text);
            int mutlakDeger = (sayi < 0) ? -1 * sayi : sayi;//sayı 0'dan küçük mü diye kontrol edilir,eğer küçük ise sayı -1 ile çarpılır.Eğer büyük ise : dan sonrası direk olarak sayı olarak alınır.
            MessageBox.Show(mutlakDeger + "");
            if (sayi<0)//If-Else bloğu yukarıdaki TernaryIF'in aynısını yapıyor.
            {
                sayi = -1 * sayi;
                MessageBox.Show(sayi+"");
            }
            else
            {
                MessageBox.Show(sayi+"");
            }
        }
    }
}
