using System;

namespace Високоcний_рiк
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = Convert.ToInt32(Console.ReadLine());
            if (y % 400 == 0 | (y % 4 == 0 & y % 100 != 0))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            int newYear = y + (4 - y % 4);
            if (newYear % 400 == 0 | (newYear % 4 == 0 & newYear % 100 != 0))
            {
                Console.WriteLine(newYear);
            }
            else
            {
                Console.WriteLine(newYear + 4);
            }
            
        
        }
    }
}
