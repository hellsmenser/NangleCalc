using System;

namespace N_angle
{
    public class Nangle
    {
        /// <summary>
        /// Площадь круга по радиусу
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public double CircleSquare(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        /// <summary>
        /// Площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double TriangleSquere(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }


        /// <summary>
        /// Проверка треугольника на прямоугольность
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool isRectangular(double a, double b, double c)
        {
            //находим большую и две меньшие стороны
            double C = Math.Max(Math.Max(a, b), c);
            double B = Math.Min(Math.Min(a, b), c);
            double A = a + b + c - C - B;

            if (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// нахождение площади правильного N-угольника по 1 стороне и их колличеству
        /// </summary>
        /// <param name="a">длинна 1 стороны</param>
        /// <param name="n">колличество сторон</param>
        /// <returns></returns>
        public double TrueNAngle(double a, int n)
        {
            double angle = 180;
            double radians = angle * (Math.PI / 180);
            double result = Math.Tan(radians);
            return ((n*Math.Pow(a,2))/(4* Math.Tan(Math.PI / n)));
        }
    }
}
