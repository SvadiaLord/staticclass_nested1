using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classe_and_constructore_opaeti.Core
{
    internal class Car
    {
        public class Engine
        {
            public int Power { get; set; }
            public int Volume { get; set; }
            public Engine() { }
            public Engine(int power, int volume)
            {
                Power = power;
                Volume = volume;   
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Мощность: {Power}, объём: {Volume}.");
            }
        }
    }
}
