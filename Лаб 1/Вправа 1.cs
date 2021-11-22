using System;

namespace Упр_1__8_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input z");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = 1 + Math.Sin(x) / Math.Sqrt(Math.Pow(x, 2) + x * Math.Pow(y, 2) + Math.Pow(x, 2) * z);

            Console.WriteLine("a = " + a);

            double b = Math.Log(Math.Pow(a, 3) + Math.Pow(x, 2)) / (x + a / (y + z / a));

            Console.WriteLine("b = " + b);

        }
    }
}
