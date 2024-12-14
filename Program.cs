using Classe_and_constructore_opaeti.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_and_constructore_opaeti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Значение поля: {Counter.InitialValue}");



            Car.Engine engine = new Car.Engine();
            engine.Power = 20;
            engine.Volume = 100;
            engine.DisplayInfo();



            Geometry.Point point1 = new Geometry.Point(3,4);
            Geometry.Point point2 = new Geometry.Point(7,1);
            double rastoynie = point1.Rastoynie(point2);
            Console.WriteLine($"Расстояние между точками: {rastoynie}");



            Shape.Circle circle = new Shape.Circle();
            circle.GetArea();
            Shape.Rectangle rectangle = new Shape.Rectangle();
            rectangle.GetArea();



            Database.Connect();
            Console.WriteLine($"подключение к базе данных: {Database.IsConnected}");
        }

    }
}