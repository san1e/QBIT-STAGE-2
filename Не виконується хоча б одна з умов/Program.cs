using System;

namespace Не_виконується_хоча_б_одна_з_умов
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = Int32.Parse(Console.ReadLine());
            //int num1 = Int32.Parse(Console.ReadLine());
            //int num2 = Int32.Parse(Console.ReadLine());
            //int num3 = Int32.Parse(Console.ReadLine());
            //int num4 = Int32.Parse(Console.ReadLine());
            if (num0 < 0 || (num0 % 10 !=0 && num0 / 10 % 10 ==0) || (num0 % 3 != 0 && num0 % 5 != 0) )
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
