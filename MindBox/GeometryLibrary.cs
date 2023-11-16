﻿namespace MindBox
{
    internal class GeometryLibrary
    {
        public interface IShape
        {
            double CalculateArea();
        }

        public class Circle : IShape
        {
            public double Radius { get; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public class Triangle : IShape
        {
            public double SideA { get; }
            public double SideB { get; }
            public double SideC { get; }

            public Triangle(double sideA, double sideB, double sideC)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }

            public double CalculateArea()
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }

            public bool IsRightTriangle()
            {
                double[] sides = { SideA, SideB, SideC };
                Array.Sort(sides);
                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
            }
        }
    }
}
