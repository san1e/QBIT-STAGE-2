using System;

namespace Рівно_одна_з_двох_умов
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
            if (num1 % 2 == 0 && (num1 < 0 && num1 % 3 == 0))
            {
                Console.WriteLine("NO");
            }
            else if (num1 % 2 == 0 || num1 < 0 && num1 % 3 == 0)
            {
                Console.WriteLine("YES");
            }
            else 
            {
                Console.WriteLine("NO");
            }
            if (num2 % 2 == 0 && (num2 < 0 && num2 % 3 == 0))
            {
                Console.WriteLine("NO");
            }
            else if (num2 % 2 == 0 || num2 < 0 && num2 % 3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num3 % 2 == 0 && (num3 < 0 && num3 % 3 == 0))
            {
                Console.WriteLine("NO");
            }
            else if (num3 % 2 == 0 || num3 < 0 && num3 % 3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num4 % 2 == 0 && (num4 < 0 && num4 % 3 == 0))
            {
                Console.WriteLine("NO");
            }
            else if (num4 % 2 == 0 || num4 < 0 && num4 % 3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num5 % 2 == 0 && (num5 < 0 && num5 % 3 == 0))
            {
                Console.WriteLine("NO");
            }
            else if (num5 % 2 == 0 || num5 < 0 && num5 % 3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
