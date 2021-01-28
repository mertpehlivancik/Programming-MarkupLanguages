using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxing_TipOgrenme_Var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //////////********BOXING********//////////
            /* Object veri tipi, içerisine atılan herhangi bir veriyi saklayabilir.
             * .Object tipi içerisine atılan her veri boxing işlemine uğrar. 
             * Yani object bir değişkenin içerisine string bir değer attığınızda 
             * RAM üzerinde string olarak değilde, object tipinde tutulur.*/
            object o1 = "ali";
            object o2 = 12.5f;
            object o3 = 'c';
            object o4 = true;

            //////////********UNBOXING********//////////
            /*Object veri tipi olarak tutulan bir değerin dışarıya çıkarılmasını 
             * istiyorsak Unboxing uygulamamız gerekmektedir. Kutudan çıkarma 
             * dediğimiz bu yöntem verinin uygun olan tipte dışarı çıkarılması 
             * işlemidir.*/
            object isim1 = "MertPehlivancık";//Boxing 
            string isim2 = (string)isim1;//Unboxing       
            //MessageBox.Show(isim2);

            //////////********Tip Öğrenme********//////////
            object nesne = "MertPehlivancık";
            Type tip = nesne.GetType();/*Burada nesnenin aldığı değişkenin tipini
                                        *type tipinde *tip* isimli bir değişkene
                                        *atadık ve mbox yardımıyla nesnenin aldığı
                                        *değerin tipini öğrendik.*/
            MessageBox.Show(tip.ToString());

            //////////********VAR TİPİ********//////////
            /*Var tipinde bir değişken tanımlarsak, değişkenin tipini biz değil 
             * derleyici tanımlayacaktır. Derleyicinin tanımladığı tipe göre o 
             * veri RAM üzerinde o tiple saklanacaktır. Var değişken tipi,diller 
             * arası,databaseler arası entegrasyonu sağlarken veri tipleri uyuşmazlığını
             * gidermek için oluşturulmuş bir tiptir.Yani C#’ta int ile tanımlanan bir 
             * değişken Delphi ‘de başka türlü tanımlanabilir.var değişken tipide bütün 
             * dillerde evrensellik özelliği taşımaktadır.*/
            var a = 09.11; //a değişkeninin tipi double dır. 
            var b = 1995; //b değişkeninin tipi int dir. 
            var c = "Mrt"; //c değişkeninin tipi string dir. 
            var d = true; //d değişkeninin tipi booldur. 
        }
    }
}
