using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Exceptionhandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntry_Click(object sender, EventArgs e)
        {
            try
            {
                var number = 9;
                var result = number / 0;

                var numbers = new int[3] { 3, 5, 8 };
                numbers[3] = 12;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"Bir Hata Oluştu. Belirtilen index dizide mevcut değil");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show($"Bir Hata Oluştu. Bir sayıyı sıfıra bölemezsiniz");
            }
        }

        private void btnNullRef_Click(object sender, EventArgs e)
        {
            Random r = null;
            var a = r.Next(0, 99);
            MessageBox.Show(a.ToString());
        }

        private void btnInvalidCast_Click(object sender, EventArgs e)
        {
            object number = "9";
            var numberAsInteger = (int)number;//Pazar anlatılacak
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            var count = 10;
            var responseCount = 4;
            var message = string.Format("Bu mesajı {0} kişi okudu, ancak {1} kişi cevap verdi", count);
        }
    }
}
