using Microsoft.Data.Sqlite;
using System;
using System.IO;
using static ZhiCoffee.Program;

namespace ZhiCoffee
{
    internal class GenChek
    {
        public void GenerateCheckWithTable()  // генерация чеков
        {
            DB db = new DB();
            db.OpenConnection();

            SqliteCommand command = new SqliteCommand("SELECT * FROM 'Check' ORDER BY ID DESC LIMIT 1", db.GetConnection()); // забираем все данные из check
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ID = Convert.ToInt32(reader["ID"]); //данные из базы в переменные
                string Adress = Convert.ToString(reader["Adress"]);
                string NCompany = Convert.ToString(reader["Name_comp"]);
                int kolvoIogurt = Convert.ToInt32(reader["total_Iogurt"]);
                int kolvoMai = Convert.ToInt32(reader["total_Mai"]);
                int kolvoMaslo = Convert.ToInt32(reader["total_Maslo"]);
                int kolvoMulo = Convert.ToInt32(reader["total_Mulo"]);
                double cost = Convert.ToDouble(reader["Cost"]);
                DateTime date = Convert.ToDateTime(reader["Date"]);

                string fileName = $"C:\\Users\\Админ\\Desktop\\chec\\Чек {DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")}.txt";
                Korzina korzina = new Korzina();
                string LoginUser = korzina.ReturnUser();


                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine($"   {NCompany}");
                    sw.WriteLine($"   Кассовый чек {ID}"); //чек с использованием переменных с данными из базы
                    sw.WriteLine("---------------------");
                    sw.WriteLine($"Оформлено {date}");
                    sw.WriteLine($"На адрес: {Adress}");
                    sw.WriteLine($"Покупатель: {LoginUser}");
                    sw.WriteLine($"Латте {kolvoMulo}шт. на сумму {Globalvert.totalMulo}р.");
                    sw.WriteLine($"Чизкейк {kolvoIogurt}шт. на сумму {Globalvert.totalIogurt}р.");
                    sw.WriteLine($"Американо {kolvoMaslo}шт. на сумму {Globalvert.totalMaslo}р.");
                    sw.WriteLine($"Капучино {kolvoMai}шт. на сумму {Globalvert.totalMai}р.");
                    sw.WriteLine($"Общая стоимость: {cost}р.");
                }
            }

            db.CloseConnection();
        }

        public void GenerateCheckWithOutTable()  // генерация чеков
        {
            DB db = new DB();
            db.OpenConnection();

            SqliteCommand command = new SqliteCommand("SELECT * FROM 'Check' ORDER BY ID DESC LIMIT 1", db.GetConnection()); // забираем все данные из check
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ID = Convert.ToInt32(reader["ID"]); //данные из базы в переменные
                string NCompany = Convert.ToString(reader["Name_comp"]);
                int kolvoIogurt = Convert.ToInt32(reader["total_Iogurt"]);
                int kolvoMai = Convert.ToInt32(reader["total_Mai"]);
                int kolvoMaslo = Convert.ToInt32(reader["total_Maslo"]);
                int kolvoMulo = Convert.ToInt32(reader["total_Mulo"]);
                double cost = Convert.ToDouble(reader["Cost"]);
                DateTime date = Convert.ToDateTime(reader["Date"]);

                string fileName = $"C:\\Users\\Админ\\Desktop\\chec\\Чек {DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")}.txt";
                Korzina korzina = new Korzina();
                string LoginUser = korzina.ReturnUser();

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine($"   {NCompany}");
                    sw.WriteLine($"   Кассовый чек {ID}"); //чек с использованием переменных с данными из базы
                    sw.WriteLine("---------------------");
                    sw.WriteLine($"Оформлено {date}");
                    sw.WriteLine($"Покупатель: {LoginUser}");
                    sw.WriteLine($"Жидкое мыло {kolvoMulo}шт. на сумму {Globalvert.totalMulo}р.");
                    sw.WriteLine($"Йогурт ванильный {kolvoIogurt}шт. на сумму {Globalvert.totalIogurt}р.");
                    sw.WriteLine($"Растительное масло {kolvoMaslo}шт. на сумму {Globalvert.totalMaslo}р.");
                    sw.WriteLine($"Майонез {kolvoMai}шт. на сумму {Globalvert.totalMai}р.");
                    sw.WriteLine($"Общая стоимость: {cost}р.");
                }
            }

            db.CloseConnection();
        }
    }
}
