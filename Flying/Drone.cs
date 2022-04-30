using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    /// <summary>
    /// Класс, описывающий дронов
    /// </summary>
    internal class Drone : IFlyable
    {
        Coord coord = new Coord(0, 0, 0);

        public void FlyTo(Coord Point)
        {
            this.coord.x = Point.x;
            this.coord.y = Point.y;
            this.coord.z = Point.z;
        }

        public double GetFlyTime(Coord Point)
        {
           double Speed = 10;
            if (GetDistance(Point) > 1000)
            {
                Console.WriteLine("Дрон не может лететь на дистанцию более 1000 км");
                return 0;
            }
            else
            {
                return GetDistance(Point) / Speed * 9 / 10;
            }
        }

        public double GetDistance(Coord Point)
        {
            return Math.Sqrt(Math.Pow(Point.x - this.coord.x, 2) + 
                Math.Pow(Point.y - this.coord.y, 2) + 
                Math.Pow(Point.z - this.coord.z, 2));
        }

    }
}
