using System.Data;
using Microsoft.Data.Sqlite;

namespace ZhiCoffee
{
    class DB
    {
        public readonly SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Админ\\Desktop\\ZhiCoffee\\CoffeeDB.db"); // подключение базы к приложению

        public void OpenConnection() //открыть подключение к базе
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection() //закрыть подключение к базе
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public SqliteConnection GetConnection() //возвращает Open/Close connection
        {
            return connection;
        }
    }
}
