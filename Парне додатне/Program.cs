using System;

namespace Парне_додатне
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            if (num > 0 && num % 2 == 0)
            {
                Console.WriteLine("YES");
                Console.WriteLine(num + 2);
            }
            else if (num > 0 && num % 2 != 0)
            {
                Console.WriteLine("NO");
                Console.WriteLine(num + 1);
            }
            else if (num < 0 && num % 2 == 0 || num % 2 != 0)
            {
                Console.WriteLine("NO");
                Console.WriteLine(2);
            }
            
        }
    }
}
