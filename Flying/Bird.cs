using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    internal class Bird : IFlyable
    {
        Coord coord = new Coord(0, 0, 0);
        public void FlyTo(Coord c) 
        {
            coord.x = c.x;
            coord.y = c.y;
            coord.z = c.z;
        }


        public double GetFlyTime(Coord c) 
        {
            Random rnd = new Random();
            return GetDistance(c) / rnd.Next(1,20);
        }

        public double GetDistance(Coord c)
        {
            return Math.Sqrt(Math.Pow(c.x - coord.x, 2) + Math.Pow(c.y - coord.y, 2) + Math.Pow(c.z - coord.z, 2));
        }

    }
}
