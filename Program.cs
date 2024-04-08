using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhiCoffee
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auto());
            Application.Exit();
        }

        public static class Globalvert // класс с переменными для количесва латте и чизкейка
        {

            public static decimal totalMai { get; set; }
            public static decimal totalMaslo { get; set; }
            public static decimal totalMulo { get; set; }
            public static decimal totalIogurt { get; set; }
#pragma warning disable IDE1006 // Стили именования
            public static decimal totalCost { get; set; }
#pragma warning restore IDE1006 // Стили именования

            public static int SuserData { get; set; }

            public static int maslo { get; set; }
            public static int mai { get; set; }
            public static int mulo { get; set; }
            public static int iogurt { get; set; }

        }
    }
}
