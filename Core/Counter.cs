using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_and_constructore_opaeti.Core
{
    internal class Counter
    {
       public static int initialValue;

        static Counter()
        {
            initialValue = 10;
            Console.WriteLine("Инициализированно значение: " + initialValue);
        }
        public static int InitialValue { get { return initialValue; } }
    }
}
