using System;

namespace Високоcний_рiк
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = Convert.ToInt32(Console.ReadLine());
            if (y % 400 == 0 ||(y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine("YES");
                Console.WriteLine(y+(4 - y % 4));
            }
            else
            {

                Console.WriteLine("NO");
                Console.WriteLine(y+ (4 - y % 4));
            }
        }
    }
}
