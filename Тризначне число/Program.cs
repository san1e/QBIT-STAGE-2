using System;

namespace Тризначне_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            if (num <= 999 && num >= 100)
            {
                Console.WriteLine(num / 100);
            }
            else
            {
                Console.WriteLine(num % 10);
            }
        }
    }
}
