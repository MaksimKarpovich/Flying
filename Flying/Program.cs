using System;

namespace Flying
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coord first = new Coord(25, 0, 0);
            Bird Bfirst = new Bird();
            Airplane Afirst = new Airplane();
            Drone Dfirst = new Drone();

            Console.WriteLine("Птица пролетит расстояние " + Bfirst.GetDistance(first) + " км за " + Bfirst.GetFlyTime(first) + " часов\n");
            Console.WriteLine("Самолет пролетит расстояние " + Afirst.GetDistance(first) + " км за " + Afirst.GetFlyTime(first) + " часов\n");
            Console.WriteLine("Дрон пролетит расстояние " + Dfirst.GetDistance(first) + " км за " + Dfirst.GetFlyTime(first) + " часов\n");
        }
    }

    /// <summary>
    /// Структура, описывающая 3-хмерную систему координат
    /// </summary>
    public struct Coord
    {
        public double X;
        public double Y;
        public double Z;

        public Coord(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
