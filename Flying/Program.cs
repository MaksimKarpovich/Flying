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
        public double x;
        public double y;
        public double z;

        public Coord(double x, double y, double z)
        {
            if(x >= 0) 
            { 
                this.x = x;
            }
            else 
            { 
                Console.WriteLine("Координата Х не может быть отрицательной");
                this.x = 0; 
            }

            if (y >= 0)
            {
                this.y = y;
            }
            else
            {
                Console.WriteLine("Координата y не может быть отрицательной");
                this.y = 0;
            }

            if (z >= 0)
            {
                this.z = z;
            }
            else
            {
                Console.WriteLine("Координата z не может быть отрицательной");
                this.z = 0;
            }
        }
    }
}
