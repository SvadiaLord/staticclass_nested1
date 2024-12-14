using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_and_constructore_opaeti.Core
{
    internal abstract class Shape
    {
        public abstract void GetArea();

        public class Circle : Shape
        {
            public override void GetArea()
            {
                Console.WriteLine("Circle реализует shape");
            }
        }
        public class Rectangle : Shape
        {
            public override void GetArea()
            {
                Console.WriteLine("Rectangle реализует shape");
            }
        }
    }
}
