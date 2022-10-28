using System;

namespace Різні_цифри_в_тризначному_числі
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
            int num4 = Int32.Parse(Console.ReadLine());
            int num5 = Int32.Parse(Console.ReadLine());
            if (num1 / 100 != num1 / 10 % 10 && num1 / 100 != num1 % 10 && num1 / 10 % 10 != num1 % 10)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num2 / 100 != num2 / 10 % 10 && num2 / 100 != num2 % 10 && num2 / 10 % 10 != num2 % 10)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num3 / 100 != num3 / 10 % 10 && num3 / 100 != num3 % 10 && num3 / 10 % 10 != num3 % 10)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num4 / 100 != num4 / 10 % 10 && num4 / 100 != num4 % 10 && num4 / 10 % 10 != num4 % 10)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num5 / 100 != num5 / 10 % 10 && num5 / 100 != num5 % 10 && num5 / 10 % 10 != num5 % 10)
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
