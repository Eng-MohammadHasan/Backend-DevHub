using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Please Enter side A :");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter side B :");
            b = Convert.ToDouble(Console.ReadLine());

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("Hypotenuse of the triangle = " + c);

            Console.ReadKey();
        }
    }
}
