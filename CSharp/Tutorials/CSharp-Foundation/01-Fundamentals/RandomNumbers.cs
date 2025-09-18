using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Random class to generate random numbers
            Random random = new Random();

            // Generate a random integer between 1 (inclusive) and 7 (exclusive)
            int num1 = random.Next(1, 7);

            // Generate a random integer between 3 (inclusive) and 5 (exclusive)
            int num2 = random.Next(3, 5);

            // Generate a random double between 0.0 (inclusive) and 1.0 (exclusive)
            double Num = random.NextDouble();

            Console.WriteLine(Num);

            Console.WriteLine(num1);

            Console.WriteLine(num2);

            Console.ReadKey();
        }
    }
}
