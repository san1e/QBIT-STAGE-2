using System;
using System.Linq;

namespace Рівно_одна_з_трьох_умов
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
           
            bool amount1 = ((num1 >= 1000 && num1 <= 9999 || num1 >= -9999 && num1 <= -1000) && num1.ToString().Distinct().Count() == num1.ToString().Length);
            bool amount2 = ((num2 >= 1000 && num2 <= 9999 || num2 >= -9999 && num2 <= -1000) && num2.ToString().Distinct().Count() == num2.ToString().Length);
            bool amount3 = ((num3 >= 1000 && num3 <= 9999 || num3 >= -9999 && num3 <= -1000) && num3.ToString().Distinct().Count() == num3.ToString().Length);
            bool amount4 = ((num4 >= 1000 && num4 <= 9999 || num4 >= -9999 && num4 <= -1000) && num4.ToString().Distinct().Count() == num4.ToString().Length);
            bool amount5 = ((num5 >= 1000 && num5 <= 9999 || num5 >= -9999 && num5 <= -1000) && num5.ToString().Distinct().Count() == num5.ToString().Length);
            bool last1 = (num1 % 10 == 3 || num1 % 10 == 6 || num1 % 10 == 9);
            bool last2 = (num2 % 10 == 3 || num2 % 10 == 6 || num2 % 10 == 9);
            bool last3 = (num3 % 10 == 3 || num3 % 10 == 6 || num3 % 10 == 9);
            bool last4 = (num4 % 10 == 3 || num4 % 10 == 6 || num4 % 10 == 9);
            bool last5 = (num5 % 10 == 3 || num5 % 10 == 6 || num5 % 10 == 9);
            bool zero1 = ((num1 >= 100 && num1 <= 999 || num1 >= -999 && num1 <= -100) && (num1 / 100 == 0 || num1 / 10 % 10 == 0 || num1 % 10 == 0));
            bool zero2 = ((num2 >= 100 && num2 <= 999 || num2 >= -999 && num2 <= -100) && (num2 / 100 == 0 || num2 / 10 % 10 == 0 || num2 % 10 == 0));
            bool zero3 = ((num3 >= 100 && num3 <= 999 || num3 >= -999 && num3 <= -100) && (num3 / 100 == 0 || num3 / 10 % 10 == 0 || num3 % 10 == 0));
            bool zero4 = ((num4 >= 100 && num4 <= 999 || num4 >= -999 && num4 <= -100) && (num4 / 100 == 0 || num4 / 10 % 10 == 0 || num4 % 10 == 0));
            bool zero5 = ((num5 >= 100 && num5 <= 999 || num5 >= -999 && num5 <= -100) && (num5 / 100 == 0 || num5 / 10 % 10 == 0 || num5 % 10 == 0));
            if (amount1 == true && last1 == false && zero1 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount1 == false && last1 == true && zero1 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount1 == false && last1 == false && zero1 == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (amount2 == true && last2 == false && zero2 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount2 == false && last2 == true && zero2 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount2 == false && last2 == false && zero2 == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (amount3 == true && last3 == false && zero3 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount3 == false && last3 == true && zero3 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount3 == false && last3 == false && zero3 == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (amount4 == true && last4 == false && zero4 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount4 == false && last4 == true && zero4 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount4 == false && last4 == false && zero4 == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (amount5 == true && last5 == false && zero5 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount5 == false && last5 == true && zero5 == false)
            {
                Console.WriteLine("YES");
            }
            else if (amount5 == false && last5 == false && zero5 == true)
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
