using System;

namespace Хоча_б_одна_з_двох_умов
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
            if (num1 % 2 != 0 || (num1 > 0 && num1 >=100 && num1 <= 999))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num2 % 2 != 0 || (num2 > 0 && num2 >= 100 && num2 <= 999))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num3 % 2 != 0 || (num3 > 0 && num3 >= 100 && num3 <= 999))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num4 % 2 != 0 || (num4 > 0 && num4 >= 100 && num4 <= 999))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num5 % 2 != 0 || (num5 > 0 && num5 >= 100 && num5 <= 999))
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
