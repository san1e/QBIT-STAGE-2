using System;

namespace Максимум_і_мінімум
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Trim().Split();
            int num1 = Convert.ToInt32(a[0]);
            int num2 = Convert.ToInt32(a[1]);
            if (num1 > num2)
            {
                Console.WriteLine(Math.Pow(num1, 2));
                Console.WriteLine(Math.Pow(num2, 2));
            }
            else
            {
                Console.WriteLine(Math.Pow(num2, 2));
                Console.WriteLine(Math.Pow(num1, 2));
            }
        }
    }
}
