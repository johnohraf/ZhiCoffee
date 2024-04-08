using Microsoft.Data.Sqlite;
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
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }
        

        private int counter = 0; //переменная для счёта нажатий по кнопке
        public Int64 SelectUsers() // метод поиска юзеров в базе
        {
            DB db = new DB();
            db.OpenConnection();
            try
            {
                SqliteCommand SelectUsers = new SqliteCommand($"SELECT ID FROM 'Users' Where (Login = '{LoginField.Text}' or Mail = '{LoginField.Text}') and Password = '{PassField.Text}'", db.GetConnection());
                return (Int64)SelectUsers.ExecuteScalar();
            }
            catch
            {
                return 0;
            }
        }

        private async void VxodButt_Click(object sender, EventArgs e) // вход
        {

            Error.Text = ""; // очистка полей ошибок
            label2.Text = "";
            if (string.IsNullOrEmpty(LoginField.Text) && string.IsNullOrEmpty(PassField.Text)) // проверка на пустое поле
            {
                Error.Text = "Логин не указан";
                label2.Text = "Пароль не указан";
            }
            else if (string.IsNullOrEmpty(LoginField.Text)) // проверка на отдельные пустые поля
                Error.Text = "Логин не указан";
            else if (string.IsNullOrEmpty(PassField.Text))// проверка на отдельные пустые поля
                label2.Text = "Пароль не указан";
            else if (LoginField.Text == "Введите почту/логин" || PassField.Text == "Введите пароль")
                MessageBox.Show("Вы не указали логин или пароль");
            else if (SelectUsers() == 0 && LoginField.Text != "" && PassField.Text != "")// если метод возвращает пробел, то аккаунта не существует
            {
                Error.Text = "Аккаунт не найден";
            }
            else if (SelectUsers() != 0)// если метод не возвращает пустую строку, то переход на страницу
            {
                Globalvert.SuserData = (int)SelectUsers();

                Hide();
                MainPage MainPage = new MainPage();
                MainPage.Show();
            }


            counter += 1; // счётчик нажатий кнопки

            while (counter >= 3) // проверка на количество попыток входа
            {
                label1.Text = "Вы превысили количество попыток входа, ожидайте 10 секунд";
                timer1.Start();
                VxodButt.Enabled = false;
                break;
            }

        }


        private void ToReg_Click(object sender, EventArgs e) // кнопка регистрации
        {
            this.Hide();
            RegPage RegPage = new RegPage();
            RegPage.Show();
        }

        public  int s = 10; // переменная для отсчёта таймера

        private void timer1_Tick(object sender, EventArgs e)
        {
            s -=1; //счёт таймера
            if (s == 0) // таймер 0, сброс счётчика нажатий, включение кнопки
            {
                timer1.Stop();
                counter = 0;
                VxodButt.Enabled = true;
                s = 10;
                label1.Text = "";
            }
       
        }

        private void label3_Click(object sender, EventArgs e) // есть ли желаемые продукты в магазине
        {
            this.Hide();
            prodnal prodnal = new prodnal();
            prodnal.Show();
        }

        private void PassField_Click(object sender, EventArgs e)
        {
            PassField.Clear();
            PassField.UseSystemPasswordChar = true;
            PassField.PasswordChar = '*';
            PassField.Click -= PassField_Click;
        }

        private void LoginField_Click(object sender, EventArgs e)
        {
            LoginField.Clear();
            LoginField.Click -= LoginField_Click;
        }

        private void Auto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
