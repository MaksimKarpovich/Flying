using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    /// <summary>
    /// Класс, описывающий птиц
    /// </summary>
    internal class Bird : IFlyable
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
            Random rnd = new Random();
            return GetDistance(Point) / rnd.Next(1,20);
        }

        public double GetDistance(Coord Point)
        {
            return Math.Sqrt(Math.Pow(Point.X - this.coord.X, 2) +
                Math.Pow(Point.Y - this.coord.Y, 2) +
                Math.Pow(Point.Z - this.coord.Z, 2));
        }

    }
}
