using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    /// <summary>
    /// Класс, описывающий самолеты
    /// </summary>
    internal class Airplane : IFlyable
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
            double Dist = GetDistance(Point);
            double Speed = 200;
            double Time = 0;

            while (Dist > 10) 
            {
                Time += 10 / Speed;
                Speed += 10;
                Dist -= 10;
            }
            return Time + Dist / Speed;
        }

        public double GetDistance(Coord Point)
        {
            return Math.Sqrt(Math.Pow(Point.x - this.coord.x, 2) +
                Math.Pow(Point.y - this.coord.y, 2) +
                Math.Pow(Point.z - this.coord.z, 2));
        }

    }
}
