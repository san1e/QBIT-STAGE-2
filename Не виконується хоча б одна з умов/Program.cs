using System;

namespace Не_виконується_хоча_б_одна_з_умов
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
            if (num0 / 1000 != 0 && num0 % 2 != 0 && num0 > 0 && num0 % 3 != 0 && num0 % 5 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            if (num1 / 1000 != 0 && num1 % 2 != 0 && num1 > 0 && num1 % 3 != 0 && num1 % 5 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            if (num2 / 1000 != 0 && num2 % 2 != 0 && num2 > 0 && num2 % 3 != 0 && num2 % 5 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            if (num3 / 1000 != 0 && num3 % 2 != 0 && num3 > 0 && num3 % 3 != 0 && num3 % 5 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            if (num4 / 1000 != 0 && num4 % 2 != 0 && num4 > 0 && num4 % 3 != 0 && num4 % 5 != 0)
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
