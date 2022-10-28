using System;

namespace Ціле_число
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Double.Parse(Console.ReadLine());
            if ( num % 1 == 0)
            {
                int num0 = Convert.ToInt32(num);
                int num1 = Convert.ToInt32(Math.Abs(num0 / 1000));
                int num2 = Convert.ToInt32(Math.Abs(num0 / 100 % 10));
                int num3 = Convert.ToInt32(Math.Abs(num0 /10 % 10));
                int num4 = Convert.ToInt32(Math.Abs(num0 % 10));
                Console.WriteLine(num1 + num2 + num3 + num4);


            }
            
            else
            {
                Console.WriteLine(Math.Abs(Math.Sqrt(num)));
            }
            
        }
    }
}
