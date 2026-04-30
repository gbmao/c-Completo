// See https://aka.ms/new-console-template for more information



using OOP;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle x, y;

            x = new Triangle();
            y = new Triangle();
            

            System.Console.WriteLine("Entre com as medidas do triangulo x: ");
            
            System.Console.Write("Lado 1: ");
            x.A = double.Parse(Console.ReadLine());
            System.Console.Write("Lado 2: ");
            x.B = double.Parse(Console.ReadLine());
            System.Console.Write("Lado 3: ");
            x.C = double.Parse(Console.ReadLine());


            System.Console.WriteLine("Entre com as medidas do triangulo y: ");
            System.Console.Write("Lado 1: ");
            y.A = double.Parse(Console.ReadLine());
            System.Console.Write("Lado 2: ");
            y.B = double.Parse(Console.ReadLine());
            System.Console.Write("Lado 3: ");
            y.C = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Area de x: {x.TriangleSize(x.A, x.B, x.C).ToString("F4")}");

            System.Console.WriteLine($"Area de y: {y.TriangleSize(y.A, y.B, y.C).ToString("F4")}");

        }

        // static double TriangleSize(double a, double b, double c)
        // {
        //     double p = (a + b + c) / 2;
        //     return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        // }
    }

}

