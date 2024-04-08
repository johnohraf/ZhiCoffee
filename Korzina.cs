using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.AxHost;
using Microsoft.Data.Sqlite;
using static ZhiCoffee.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ZhiCoffee
{
    public partial class Korzina : Form
    {
        

        public Korzina()
        {
            InitializeComponent(); //инициализация
            Kolvo_mai.Text = Globalvert.mai.ToString(); // указание количество уже добавленного латте
            Kolvo_iogurt.Text = Globalvert.iogurt.ToString();// указание количество уже добавленного латте
            Kolvo_maslo.Text = Globalvert.maslo.ToString();
            Kolvo_mulo.Text = Globalvert.mulo.ToString();
            totcost();
            NumberStol.Enabled = false;
            NumberStol.Visible = false;


        }
        public void totcost() 
        {
            Globalvert.totalMulo = 0;
            Globalvert.totalMaslo = 0;
            Globalvert.totalMai = 0;
            Globalvert.totalIogurt = 0;

            for (int i = 1; i <= Globalvert.iogurt; i++)
                Globalvert.totalIogurt += 69;
            for (int i = 1; i <= Globalvert.mai; i++)
                Globalvert.totalMai += 300; //общ стоимости латте
            for (int i = 1; i <= Globalvert.maslo; i++)
                Globalvert.totalMaslo += 218;
            for (int i = 1; i <= Globalvert.mulo; i++)
                Globalvert.totalMulo += 89;

            Globalvert.totalCost = Globalvert.totalMaslo + Globalvert.totalMulo + Globalvert.totalMai + Globalvert.totalIogurt; // общая стоимость
            label1.Text = $"Общая стоимость заказа: \n{Globalvert.totalCost}";
        }
        

        public string ReturnUser() // проверка на сущ юзера
        {
            DB db = new DB();

            db.OpenConnection();

            SqliteCommand ReturnUser = new SqliteCommand($"SELECT Login FROM 'Users' Where ID = '{Globalvert.SuserData}'", db.GetConnection());
            return ReturnUser.ExecuteScalar().ToString();
        }

        public void InsertCheckZastolom() // заполнение базы данными юзеров из полей
        {
            DB db = new DB();
            db.OpenConnection();

            SqliteCommand InsertCheck = new SqliteCommand($"INSERT INTO 'Check' ('ID_user', 'Adress', 'Name_comp', 'total_Iogurt', 'total_Mai', 'total_Maslo', 'total_Mulo', 'Kolvo_mai', 'Kolvo_Maslo','Kolvo_Iogurt', 'Kolvo_mulo', 'Cost', 'Date') VALUES ('{Globalvert.SuserData}', '{NumberStol.Text}', 'ООО EFKO', '{Globalvert.totalIogurt}', '{Globalvert.totalMai}', '{Globalvert.totalMaslo}',  '{Globalvert.totalMulo}', '{Globalvert.mai}', '{Globalvert.maslo}', '{Globalvert.iogurt}',  '{Globalvert.mulo}', '{Globalvert.totalCost}', '{DateTime.Now}')", db.GetConnection());
            InsertCheck.ExecuteNonQuery();

            db.CloseConnection();
        }

        public void InsertCheckSsoboy() // заполнение базы данными юзеров из полей
        {
            DB db = new DB();
            db.OpenConnection();

            SqliteCommand InsertCheck = new SqliteCommand($"INSERT INTO 'Check' ('ID_user', 'Name_comp', 'total_Iogurt', 'total_Mai', 'total_Maslo', 'total_Mulo', 'Kolvo_mai', 'Kolvo_Maslo','Kolvo_Iogurt', 'Kolvo_mulo', 'Cost', 'Date') VALUES ('{Globalvert.SuserData}', 'ООО EFKO', '{Globalvert.totalIogurt}', '{Globalvert.totalMai}', '{Globalvert.totalMaslo}',  '{Globalvert.totalMulo}', '{Globalvert.mai}', '{Globalvert.maslo}', '{Globalvert.iogurt}',  '{Globalvert.mulo}', '{Globalvert.totalCost}', '{DateTime.Now}')", db.GetConnection());
            InsertCheck.ExecuteNonQuery();

            db.CloseConnection();
        }


        private void MinesCake_Click(object sender, EventArgs e)
        {
            Globalvert.iogurt -= 1; // подсчёт кол во чиз
            Kolvo_iogurt.Text = Globalvert.iogurt.ToString();
            totcost();

        }

        private void PlusCake_Click(object sender, EventArgs e)
        {
            Globalvert.iogurt += 1; // плюс ван кэйк
            Kolvo_iogurt.Text = Globalvert.iogurt.ToString(); //cake
            totcost();

        }

        private void PlusLatte_Click(object sender, EventArgs e)
        {
            Globalvert.mai += 1; //плюс ван латте
            Kolvo_mai.Text = Globalvert.mai.ToString(); // латте
            totcost();

        }

        private void MinesLatte_Click(object sender, EventArgs e)
        {
            Globalvert.mai -= 1; // минус ван латте
            Kolvo_mai.Text = Globalvert.mai.ToString();
            totcost();

        }
        private void Mines_Chino_Click(object sender, EventArgs e)
        {
            Globalvert.maslo -= 1; // минус ван латте
            Kolvo_maslo.Text = Globalvert.maslo.ToString();
            totcost();

        }

        private void Plus_Chino_Click(object sender, EventArgs e)
        {
            Globalvert.maslo += 1; // минус ван латте
            Kolvo_maslo.Text = Globalvert.maslo.ToString();
            totcost();

        }

        private void Mines_Amer_Click(object sender, EventArgs e)
        {
            Globalvert.mulo -= 1; // минус ван латте
            Kolvo_mulo.Text = Globalvert.mulo.ToString();
            totcost();

        }

        private void Plus_Amer_Click(object sender, EventArgs e)
        {
            Globalvert.mulo += 1; // минус ван латте
            Kolvo_mulo.Text = Globalvert.mulo.ToString();
            totcost();

        }

        private void Buy_Click(object sender, EventArgs e)
        {

            //проверка на пустой заказ или отрицательные числа 
            if (Convert.ToInt32(Kolvo_maslo.Text) < 0 || Convert.ToInt32(Kolvo_iogurt.Text) < 0 || Convert.ToInt32(Kolvo_mai.Text) < 0 || Convert.ToInt32(Kolvo_mulo.Text) < 0)
                MessageBox.Show("Вы не можете заказать  отрицательное число продуктов ");
            else if (Convert.ToInt32(Kolvo_maslo.Text) == 0 && Convert.ToInt32(Kolvo_iogurt.Text) == 0 && Convert.ToInt32(Kolvo_mai.Text) == 0 && Convert.ToInt32(Kolvo_mulo.Text) == 0)
                MessageBox.Show($"Вы не можете сделать пустой заказ.");
            else if (NumberStol.Text == "Введите адрес доставки" && NumberStol.Visible == true)
                MessageBox.Show("Вы не ввели адрес доставки");
            else if (NumberStol.Text == "" && NumberStol.Visible == true)
                MessageBox.Show("Вы не ввели адрес доставки");
            else
            {

                GenChek genChek = new GenChek();
                if (NumberStol.Visible == false)
                {
                    InsertCheckSsoboy();
                    genChek.GenerateCheckWithOutTable();
                }
                else
                {
                    genChek.GenerateCheckWithTable();
                    InsertCheckZastolom();
                }

                MessageBox.Show($"Ваш заказ успешно оформлен."); // дейт берёт сейчас время и кидает в м бокс
            }
            totcost();

        }


        private void NumberStol_Click(object sender, EventArgs e) // текст бокс для указа за каким столом
        {
            NumberStol.Clear();
        }

        private void RadioZaStolom_CheckedChanged(object sender, EventArgs e) // выдача заказа за столом
        {
            NumberStol.Enabled = true;
            NumberStol.Visible = true;
        }


        private void Korzina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}