using System;

namespace Парність_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(Math.Pow(a,2));
            }
            else
            {
                Console.WriteLine(a-1);
            }
        }
    }
}
