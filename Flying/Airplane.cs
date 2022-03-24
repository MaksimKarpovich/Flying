using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    internal class Airplane
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
            double Dist = GetDistance(c);
            double Speed = 200;
            double Time = 0;
            while (Dist > 10) 
            {
                Time += 10 / Speed;
                Speed += 10;
                Dist -= 10;
            }
            return  Time + Dist / Speed;
        }

        public double GetDistance(Coord c)
        {
            return Math.Sqrt(Math.Pow(c.x - coord.x, 2) + Math.Pow(c.y - coord.y, 2) + Math.Pow(c.z - coord.z, 2));
        }

    }
}
