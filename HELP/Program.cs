using System;

namespace HELP
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            if ((num1 >= 100 && num1 <= 999 || num1 >= -999 && num1 <= -100) && (num1 % 2 == 0 && num1 < 0) && (num1 % 3 == 0 && num1 % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            if ((num2 >= 100 && num2 <= 999 || num2 >= -999 && num2 <= -100) && (num2 % 2 == 0 && num2 < 0) && (num2 % 3 == 0 && num2 % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            if ((num3 >= 100 && num3 <= 999 || num3 >= -999 && num3 <= -100) && (num3 % 2 == 0 && num3 < 0) && (num3 % 3 == 0 && num3 % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            if ((num4 >= 100 && num4 <= 999 || num4 >= -999 && num4 <= -100) && (num4 % 2 == 0 && num4 < 0) && (num4 % 3 == 0 && num4 % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            if ((num5 >= 100 && num5 <= 999 || num5 >= -999 && num5 <= -100) && (num5 % 2 == 0 && num5 < 0) && (num5 % 3 == 0 && num5 % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}