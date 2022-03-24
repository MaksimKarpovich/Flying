using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    internal class Drone
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
            double Speed = 10;
           if(GetDistance(c) > 1000) 
           {
                Console.WriteLine("Дрон не может лететь на дистанцию более 1000 км");
                return 0;
           }
           else
           return GetDistance(c) / Speed * 9 / 10;
        }

        public double GetDistance(Coord c)
        {
            return Math.Sqrt(Math.Pow(c.x - coord.x, 2) + Math.Pow(c.y - coord.y, 2) + Math.Pow(c.z - coord.z, 2));
        }

    }
}
