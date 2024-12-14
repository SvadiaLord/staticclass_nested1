using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_and_constructore_opaeti.Core
{
    internal class Geometry
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point() { }
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double Rastoynie(Point Yes)
            {
                double rastX = Yes.X - this.X;
                double rastY = Yes.Y - this.Y;
                return (rastX * rastX + rastY * rastY);
            }
        }
    }
}
