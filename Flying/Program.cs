using System;

namespace Flying
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coord first = new Coord(25, 0, 0);
            Bird Bfirst = new Bird();
            Console.WriteLine("Птица пролетит расстояние " + Bfirst.GetDistance(first) + " км за " + Bfirst.GetFlyTime(first) + " часов\n");
                        
            Airplane Afirst = new Airplane();
            Console.WriteLine("Самолет пролетит расстояние " + Afirst.GetDistance(first) + " км за " + Afirst.GetFlyTime(first) + " часов\n");
            
            Drone Dfirst = new Drone();
            Console.WriteLine("Дрон пролетит расстояние " + Dfirst.GetDistance(first) + " км за " + Dfirst.GetFlyTime(first) + " часов\n");
        }





        
    }
}
