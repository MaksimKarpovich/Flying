using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    /// <summary>
    /// Класс, описывающий самолеты
    /// </summary>
    internal class Airplane
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
            return Math.Sqrt(Math.Pow(Point.X - this.coord.X, 2) +
                Math.Pow(Point.Y - this.coord.Y, 2) +
                Math.Pow(Point.Z - this.coord.Z, 2));
        }

    }
}
