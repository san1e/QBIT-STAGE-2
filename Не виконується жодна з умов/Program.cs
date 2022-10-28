using System;

namespace Не_виконується_жодна_з_умов
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            if ((num1 >= 100 && num1 <= 999 && num1 >= -999 && num1 <= -100) || (num1 % 2 ==0 && num1 <0) || (num1 % 3 == 0 || num1 % 5 != 0))
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
