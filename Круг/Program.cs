using System;

namespace Круг
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Trim().Split();
            double x1 = double.Parse(firstLine[0]);
            double y1 = double.Parse(firstLine[1]);
            string[] secondLine = Console.ReadLine().Trim().Split();
            double x2 = double.Parse(secondLine[0]);
            double y2 = double.Parse(secondLine[1]);
            string[] thirdLine = Console.ReadLine().Trim().Split();
            double x3 = double.Parse(thirdLine[0]);
            double y3 = double.Parse(thirdLine[1]);
            string[] fourthLine = Console.ReadLine().Trim().Split();
            double x4 = double.Parse(fourthLine[0]);
            double y4 = double.Parse(fourthLine[1]);
            string[] fifthLine = Console.ReadLine().Trim().Split();
            double x5 = double.Parse(fifthLine[0]);
            double y5 = double.Parse(fifthLine[1]);
            string[] sixthLine = Console.ReadLine().Trim().Split();
            double A = double.Parse(sixthLine[0]);
            double B = double.Parse(sixthLine[1]);
            double R = double.Parse(sixthLine[2]);
            if (Math.Sqrt(Math.Pow(x1-A, 2) + Math.Pow(y1-B, 2)) <= R)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Math.Sqrt(Math.Pow(x2-A, 2) + Math.Pow(y2-B, 2)) <= R)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Math.Sqrt(Math.Pow(x3-A, 2) + Math.Pow(y3-B, 2)) <= R)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Math.Sqrt(Math.Pow(x4-A, 2) + Math.Pow(y4-B, 2)) <= R)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Math.Sqrt(Math.Pow(x5-A, 2) + Math.Pow(y5-B, 2)) <= R)
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
