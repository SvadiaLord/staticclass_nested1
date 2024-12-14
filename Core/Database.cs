using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_and_constructore_opaeti.Core
{
    internal class Database
    {
        public static bool IsConnected { get; set; }
        static Database()
        {
            IsConnected = false;
        }
        public static void Connect()
        {
            IsConnected = true;
            Console.WriteLine("Подключен к базе данных.");
        }
    }
}
