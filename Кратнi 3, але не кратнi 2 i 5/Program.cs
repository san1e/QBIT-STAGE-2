using System;

namespace Кратнi_3__але_не_кратнi_2_i_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = Int32.Parse(Console.ReadLine());
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
            int num4 = Int32.Parse(Console.ReadLine());
            if (num0 % 3 == 0 && num0 % 2 != 0 && num0 % 5 != 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num1 % 3 == 0 && num1 % 2 != 0 && num1 % 5 != 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num2 % 3 == 0 && num2 % 2 != 0 && num2 % 5 != 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num3 % 3 == 0 && num3 % 2 != 0 && num3 % 5 != 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num4 % 3 == 0 && num4 % 2 != 0 && num4 % 5 != 0)
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
