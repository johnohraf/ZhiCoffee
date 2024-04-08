using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;
using static ZhiCoffee.Program;
using System.Text.RegularExpressions; 

namespace ZhiCoffee
{
    public partial class RegPage : Form
    {
        public RegPage()
        {
            InitializeComponent();
        }
       
        public int counterreg = 0; // переменная для счёчика

        public void InsertUsers() // заполнение базы данными юзеров из полей
        {

            DB db = new DB();
            db.OpenConnection();

            SqliteCommand InsertUsers = new SqliteCommand($"INSERT INTO 'Users' ('Login','Password', 'Mail') VALUES ('{LoginRegField.Text}','{PassRegField.Text}', '{MailField.Text.ToLower()}')", db.GetConnection());
            InsertUsers.ExecuteNonQuery();

            db.CloseConnection();
        }
        public Int64 SelectRegUsers() // метод поиска юзеров в базе
        {
            DB db = new DB();
            db.OpenConnection();

            SqliteCommand SelectUsers = new SqliteCommand($"SELECT ID FROM 'Users' Where Login = '{LoginRegField.Text}' and Mail = '{MailField.Text.ToLower()}'", db.GetConnection());
            return (Int64)SelectUsers.ExecuteScalar();
        }

        public Int64 CheckUsersLogin() // проверка на сущ юзера
        {
            DB db = new DB();
            db.OpenConnection();

            try
            {
                SqliteCommand CheckUsers = new SqliteCommand($"SELECT ID FROM 'Users' Where Login = '{LoginRegField.Text}'", db.GetConnection());
                return (Int64)CheckUsers.ExecuteScalar();
            }
            catch
            {
                return 0;
            }
        }
        public Int64 CheckUsersMail() // проверка на сущ юзера
        {
            DB db = new DB();
            db.OpenConnection();

            try
            {
                SqliteCommand CheckUsers = new SqliteCommand($"SELECT ID FROM 'Users' Where mail = '{MailField.Text}'", db.GetConnection());
                return (Int64)CheckUsers.ExecuteScalar();
            }
            catch
            {
                return 0;
            }
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            ErrorMail.Text = "";
            ErrorPass.Text = "";
            ErrorLog.Text = "";
            if (!Regex.IsMatch(MailField.Text.ToLower(), @"^[a-zA-Z0-9._-]+@(mail\.ru|yandex\.ru|gmail\.com)$"))
            {
                ErrorMail.Text = "E-mail введён не корректно";
            }

            if (string.IsNullOrEmpty(MailField.Text) && string.IsNullOrEmpty(PassRegField.Text) && string.IsNullOrEmpty(LoginRegField.Text)) //проверка на 2 пустых поля
            {// проверка на пустое поле
                ErrorMail.Text = "Почта не указана";
                ErrorPass.Text = "Пароль не указан";
                ErrorLog.Text = "Логин не указан";
            }
            else if (string.IsNullOrEmpty(LoginRegField.Text))//проверка на одно пустых поля
                ErrorMail.Text = "Логин не указан";
            else if (string.IsNullOrEmpty(PassRegField.Text))//проверка на одно пустых поля
                ErrorPass.Text = "Пароль не указан";
            else if (string.IsNullOrEmpty(MailField.Text))//проверка на одно пустых поля
                ErrorPass.Text = "Почта не указана";
            else if (LoginRegField.Text == "Введите почту/логин" || PassRegField.Text == "Введите пароль" || MailField.Text == "")
                MessageBox.Show("Вы не указали логин, почту или пароль");
            else if (CheckUsersLogin() == 0 && CheckUsersMail() == 0 && MailField.Text != "" && PassRegField.Text != "" && LoginRegField.Text != "" && Regex.IsMatch(MailField.Text, @"^[a-zA-Z0-9._]+@(mail\.ru|yandex\.ru|gmail\.com)$")) //если поля не пустые и метод возвращает что нет юзеров
            {
                InsertUsers(); //вызов метода
                Globalvert.SuserData = (int)SelectRegUsers();

                this.Hide();
                MainPage MainPage = new MainPage();
                MainPage.Show();
            }
            else if (CheckUsersLogin() != 0) // если пользователь есть такой идите лесом
                ErrorLog.Text = "Логин занят";
            else if (CheckUsersMail() != 0)
                ErrorMail.Text = "Такой E-mail уже зарегистрирован";

            counterreg += 1;// счётчик кликов

            // ограничение кликов 
            do
            {
                if (counterreg >= 6)
                {
                    label1.Text = "Вы превысили количество попыток регистрации, ожидайте 10 секунд";
                    timerReg.Start();
                    RegBut.Enabled = false;
                    break;
                }
            } while (counterreg >= 6);
            
        }

        public int ch = 10; // переменная для отчёта секунд
#pragma warning disable IDE1006 // Стили именования
        private void timerReg_Tick(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {
            ch -= 1;
            if (ch == 0) // всё аналогично с auto.cs
            {
                timerReg.Stop();
                counterreg = 0;
                RegBut.Enabled = true;
                ch = 10;
                label1.Text = "";
            }
        }

        private void MailField_Click(object sender, EventArgs e)
        {
            MailField.Clear();
            MailField.Click -= MailField_Click;
        }

        private void LoginRegField_Click(object sender, EventArgs e)
        {
            LoginRegField.Clear();
            LoginRegField.Click -= LoginRegField_Click;
        }



        private void PassRegField_Click(object sender, EventArgs e)
        {
            PassRegField.Clear();
            PassRegField.UseSystemPasswordChar = true;
            PassRegField.PasswordChar = '*';
            PassRegField.Click -= PassRegField_Click;
        }

        private void RegPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

#pragma warning disable IDE1006 // Стили именования
        private void pictureBox1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {
            Hide();
            Auto auto = new Auto();
            auto.Show();
        }
    }
}
