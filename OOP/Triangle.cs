using System;

namespace OOP;

public class Triangle
{
    public double A;
    public double B;
    public double C;

    public double TriangleSize(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
}
