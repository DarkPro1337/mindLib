using System;

namespace mindLib
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (IsExist(a, b, c))
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
        }

        private static bool IsExist(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new TriangleEx("Такого треугольника не существует, так как одна из сторон меньше нуля!");
            }
            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new TriangleEx("Такого треугольника не существует, так как одна из сторон больше двух других!");
            }
            return true;
        }

        public override double Area()
        {
            var p = (SideA + SideB + SideC) / 2;
            var square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return square;
        }

        public bool IsStraight()
        {
            bool isStraight = (SideA == Math.Sqrt(Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) ||
                               SideB == Math.Sqrt(Math.Pow(SideC, 2) - Math.Pow(SideA, 2)) ||
                               SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));
            return isStraight;
        }
    }
}
