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
            this.coord.x = Point.x;
            this.coord.y = Point.y;
            this.coord.z = Point.z;
        }

        public double GetFlyTime(Coord Point) 
        {
            Random rnd = new Random();
            return GetDistance(Point) / rnd.Next(1,20);
        }

        public double GetDistance(Coord Point)
        {
            return Math.Sqrt(Math.Pow(Point.x - this.coord.x, 2) +
                Math.Pow(Point.y - this.coord.y, 2) +
                Math.Pow(Point.z - this.coord.z, 2));
        }

    }
}
