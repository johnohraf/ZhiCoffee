using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhiCoffee
{
    public partial class prodnal : Form
    {
        public prodnal()
        {
            InitializeComponent();
        }

        private void VxodButt_Click(object sender, EventArgs e)
        {
            string[] prod = { "Латте", "Чизкейк" }; //масиив
            string FindProd = comboBox1.Text; // из бокса в переменную
            foreach (string s in prod)  //проход по массиву
            {
                if (FindProd == s) // если совпадает с дынными пользователя то есть
                    MessageBox.Show($"Поздравляем, у нас в наличии имеется {s}");
            }
        }
    }
}
