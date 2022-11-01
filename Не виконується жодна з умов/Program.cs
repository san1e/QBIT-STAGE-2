using System;

namespace Не_виконується_жодна_з_умов
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
            bool amount1 = (num1 >= 100 && num1 <= 999 || num1 >= -999 && num1 <= -100);
            bool amount2 = (num2 >= 100 && num2 <= 999 || num2 >= -999 && num2 <= -100);
            bool amount3 = (num3 >= 100 && num3 <= 999 || num3 >= -999 && num3 <= -100);
            bool amount4 = (num4 >= 100 && num4 <= 999 || num4 >= -999 && num4 <= -100);
            bool amount5 = (num5 >= 100 && num5 <= 999 || num5 >= -999 && num5 <= -100);
            bool even1 = (num1 % 2 == 0 && num1 < 0);
            bool even2 = (num2 % 2 == 0 && num2 < 0);
            bool even3 = (num3 % 2 == 0 && num3 < 0);
            bool even4 = (num4 % 2 == 0 && num4 < 0);
            bool even5 = (num5 % 2 == 0 && num5 < 0);
            bool multiply1 = (num1 % 3 == 0 && num1 % 5 != 0);
            bool multiply2 = (num2 % 3 == 0 && num2 % 5 != 0);
            bool multiply3 = (num3 % 3 == 0 && num3 % 5 != 0);
            bool multiply4 = (num4 % 3 == 0 && num4 % 5 != 0);
            bool multiply5 = (num5 % 3 == 0 && num5 % 5 != 0);
            if (amount1 == false && even1 == false && multiply1 == false)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (amount2 == false && even2 == false && multiply2 == false)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (amount3 == false && even3 == false && multiply3 == false)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (amount4 == false && even4 == false && multiply4 == false)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (amount5 == false && even5 == false && multiply5 == false)
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
