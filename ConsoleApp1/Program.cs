using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = Int32.Parse(Console.ReadLine());
            
            if (num0 < 0 && num0 % 10 != 0 && (num0 / 10) % 10 == 0 && (num0 % 3 != 0) && (num0 % 5 != 0))
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
