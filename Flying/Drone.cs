using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    /// <summary>
    /// Класс, описывающий дронов
    /// </summary>
    internal class Drone
    {
        Coord coord = new Coord(0, 0, 0);

        public void FlyTo(Coord Point)
        {
            this.coord.X = Point.X;
            this.coord.Y = Point.Y;
            this.coord.Z = Point.Z;
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
            return Math.Sqrt(Math.Pow(Point.X - this.coord.X, 2) + 
                Math.Pow(Point.Y - this.coord.Y, 2) + 
                Math.Pow(Point.Z - this.coord.Z, 2));
        }

    }
}
