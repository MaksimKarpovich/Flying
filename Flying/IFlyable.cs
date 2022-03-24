using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    public interface IFlyable
    {
        public void FlyTo(Coord c);

        public double GetFlyTime(Coord c);

        public double GetDistance(Coord c);
    }

    public struct Coord
    {
        public double x;
        public double y;
        public double z;

        public Coord(double X, double Y, double Z) 
        {
            x = X;
            y = Y;
            z = Z;
        }
    }
}
