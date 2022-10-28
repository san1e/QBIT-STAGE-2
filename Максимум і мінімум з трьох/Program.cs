using System;

namespace Максимум_і_мінімум_з_трьох
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max;
            int min;
            if (num1 > num2 && num1 > num3)
            {
                max = num1;
                Console.WriteLine(max * max);
            }
            else if (num2 > num3)
            {
                max = num2;
                Console.WriteLine(max * max);
            }
            else
            {
                max = num3;
                Console.WriteLine(max * max);
            }
            if (num1 < num2 && num1 < num3)
            {
                min = num1;
                Console.WriteLine(min * min);
            }
            else if (num2 > num3)
            {
                min = num3;
                Console.WriteLine(min * min);
            }
            else
            {
                min = num2;
                Console.WriteLine(min * min);
            }

        }
    }
}
