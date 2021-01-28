using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefAndOutParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
        }
        int x = 10;
        int y = 20;
        void degistir()
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            MessageBox.Show("x: and y: " +x + y);
        }
        private void Degistir(ref int x, ref int y)
        {
              /*Ref anahtar kelimesini kullandığımızda metotlara değişkenlerin 
          * adresleri geçirilir. C# ta bu işlemi yapmak için gösterici yerine
          * yeni bir anahtar sözcük olan ref kullanılır. ref anahtar sözcüğü 
          * değer türlerinin metotlara referans yolu ile geçirilmesini sağlar*/

              /*Unutmamamız gereken nokta metot çağrımının da ref anahtar sözcüğü ile 
         * birlikte yapılması zorunluluğudur. Ref sözcüğünün kullanımı ile ilgili 
         * diğer bir önemli nokta ise ref ile kullanılacak değişkenlere mutlaka değer 
         * atanmış olma zorunluluğudur. Herhangi bir değer verilmemiş değişkeni ref 
         * ile de olsa kullanamayız. Kullandığımız takdirde ise derleme aşamasında 
         * "Use of unassigned local variable" hatasını alırız.*/ 
           
            int temp = x;
            x = y;
            y = temp;
        }            
        private void btnDeneme_Click(object sender, EventArgs e)
        {
            //int a = 5;
            //int b = 9;
            //MessageBox.Show(x + "");
            //degistir();
            //Degistir(ref a, ref b);//çağırırken de referansını verdik.
            //MessageBox.Show("a'nın değeri : " + a.ToString());//a = 9        
            bool islemSonucu; 
            Donustur("23", out islemSonucu);
            MessageBox.Show(Donustur("23", out islemSonucu).ToString());
            MessageBox.Show(islemSonucu.ToString()); 
        }
        int Donustur(string sayi, out bool islemSonucu) 
        { 
            try 
            { 
                int donusturulen = Convert.ToInt32(sayi); 
                islemSonucu = true; 
                return donusturulen; 
            } 
            catch 
            { 
                islemSonucu = false; return 0; 
            } 
        }  
    }
}
