using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZhiCoffee.Program;
namespace ZhiCoffee
{
    

    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;


        }

        private void Buy_Latte_Click(object sender, EventArgs e)
        {
            Globalvert.maslo += 1;//подсчёт количесва заказанного латте
        }

        private void Buy_Cake_Click(object sender, EventArgs e)
        {
            //подсчёт количесва заказанного чизкейка
            Globalvert.mai += 1;
        }

        private void Buy_chino_Click(object sender, EventArgs e)
        {
            Globalvert.iogurt += 1;
        }

        private void Buy_amer_Click(object sender, EventArgs e)
        {
            Globalvert.mulo += 1;
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Korzina Korzina = new Korzina();
            Korzina.Show();
        }
    }
}
