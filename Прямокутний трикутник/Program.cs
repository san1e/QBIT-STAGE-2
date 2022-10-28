using System;

namespace Прямокутний_трикутник
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            uint a = uint.Parse(data[0]);
            uint b = uint.Parse(data[1]);
            uint c = uint.Parse(data[2]);
           
            uint sum = a + b + c;
            
            if (a * a + b * b ==c*c)
            {
                Console.WriteLine((a*b)/2);
            }
             if (a*a + c*c == b*b)
            {
                Console.WriteLine((a*c)/2);
            }
             if (c*c + b*b == a*a)
            {
                Console.WriteLine((c*b)/2);
            }
             if ((a*a + b*b != c*c)&&(a*a + c*c != b*b)&&(c*c + b*b != a*a))  
            {
                Console.WriteLine(sum);
            }
            
        }
    }
}
