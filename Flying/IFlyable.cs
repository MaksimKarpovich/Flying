using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    /// <summary>
    /// Родительский интерфейс для классов, описывающих летающие объекты
    /// </summary>
    public interface IFlyable
    {
        /// <summary>
        /// Метод, изменяющий текущую координату
        /// </summary>
        public void FlyTo(Coord Point);

        /// <summary>
        /// Метод, возвращающий время полета до точки из текущего положения
        /// </summary>
        public double GetFlyTime(Coord Point);

        /// <summary>
        /// Метод, возвращающий расстояние от текущей точки до новой
        /// </summary>
        public double GetDistance(Coord Point);
    }
}
