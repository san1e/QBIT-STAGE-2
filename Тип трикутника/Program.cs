using System;

namespace Тип_трикутника
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double a = Double.Parse(data[0]);
            double b = Double.Parse(data[1]);
            double c = Double.Parse(data[2]);
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Incorrect data.");
            }
            else if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Triangle does not exist.");
            }
            else
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Equilateral triangle.");
                }
                else if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
                {
                    Console.WriteLine("Isosceles triangle.");
                }
                else if (a != b && a != c && b !=c)
                {
                    Console.WriteLine("Sided triangle.");
                }
            }
            
        }
    }
}
