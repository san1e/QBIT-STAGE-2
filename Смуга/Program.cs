using System;
using System.Linq;

namespace Смуга
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Trim().Split();
            double num1 = double.Parse(firstLine[0]);
            double num2 = double.Parse(firstLine[1]);
            string[] secondLine = Console.ReadLine().Trim().Split();
            double num3 = double.Parse(secondLine[0]);
            double num4 = double.Parse(secondLine[1]);
            string[] thirdLine = Console.ReadLine().Trim().Split();
            double num5 = double.Parse(thirdLine[0]);
            double num6 = double.Parse(thirdLine[1]);
            string[] fourthLine = Console.ReadLine().Trim().Split();
            double num7 = double.Parse(fourthLine[0]);
            double num8 = double.Parse(fourthLine[1]);
            string[] fifthLine = Console.ReadLine().Trim().Split();
            double num9 = double.Parse(fifthLine[0]);
            double num10 = double.Parse(fifthLine[1]);
            string[] sixthLine = Console.ReadLine().Trim().Split();
            double x = double.Parse(sixthLine[0]);
            double y = double.Parse(sixthLine[1]);
            double[] nums = { x, y };
            double A = nums.Max();
            double B = nums.Min();

            if (num1 >= B && num1 <= A )
            { 
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num3 >= B && num3 <= A)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num5 >= B && num5 <= A)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num7 >= B && num7 <= A)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num9 >= B && num9 <= A)
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
