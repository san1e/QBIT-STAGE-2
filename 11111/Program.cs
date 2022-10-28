using System;

namespace _11111
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Double.Parse(Console.ReadLine());
            Console.WriteLine((int)num / 10000);
            Console.WriteLine((int)num / 1000 % 100 % 10);
            Console.WriteLine((int)num % 1000 / 100);
            Console.WriteLine((int)num % 100);
            Console.WriteLine((int)num % 10);
        }
    }
}
