using System;

namespace Квадрат
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
            double A = double.Parse(sixthLine[0]);

            if (num1 >= A/ (-2) && num1 <= A/2 && num2 >= A/(-2) && num2 <= A/2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num3 >= A / (-2) && num3 <= A / 2 && num4 >= A / (-2) && num4 <= A / 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num5 >= A / (-2) && num5 <= A / 2 && num6 >= A / (-2) && num6 <= A / 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num7 >= A / (-2) && num7 <= A / 2 && num8 >= A / (-2) && num8 <= A / 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (num9 >= A / (-2) && num9 <= A / 2 && num10 >= A / (-2) && num10 <= A / 2)
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
