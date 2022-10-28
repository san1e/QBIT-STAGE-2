using System;

namespace Прямокутник
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
            double X1 = double.Parse(sixthLine[0]);
            double Y1 = double.Parse(sixthLine[1]);
            double X2 = double.Parse(sixthLine[2]);
            double Y2 = double.Parse(sixthLine[3]);
            if (X1 > X2 && Y1 > Y2)
            {
                if (num1 <= X1 && num1 >= X2 && num2 <= Y1 && num2 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num3 <= X1 && num3 >= X2 && num4 <= Y1 && num4 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num5 <= X1 && num5 >= X2 && num6 <= Y1 && num6 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num7 <= X1 && num7 >= X2 && num8 <= Y1 && num8 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num9 <= X1 && num9 >= X2 && num10 <= Y1 && num10 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else if (X2 > X1 &&  Y2 > Y1)
            {
                if (num1 <= X2 && num1 >= X1 && num2 <= Y2 && num2 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num3 <= X2 && num3 >= X1 && num4 <= Y2 && num4 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num5 <= X2 && num5 >= X1 && num6 <= Y2 && num6 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num7 <= X2 && num7 >= X1 && num8 <= Y2 && num8 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num9 <= X2 && num9 >= X1 && num10 <= Y2 && num10 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else if (X1 > X2 && Y1 < Y2)
            {
                if (num1 <= X1 && num1 >= X2 && num2 <= Y2 && num2 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num3 <= X1 && num3 >= X2 && num4 <= Y2 && num4 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num5 <= X1 && num5 >= X2 && num6 <= Y2 && num6 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num7 <= X1 && num7 >= X2 && num8 <= Y2 && num8 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num9 <= X1 && num9 >= X2 && num10 <= Y2 && num10 >= Y1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else if (X1 < X2 && Y1 > Y2)
            {
                if (num1 <= X2 && num1 >= X1 && num2 <= Y1 && num2 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num3 <= X2 && num3 >= X1 && num4 <= Y1 && num4 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num5 <= X2 && num5 >= X1 && num6 <= Y1 && num6 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num7 <= X2 && num7 >= X1 && num8 <= Y1 && num8 >= Y2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                if (num9 <= X2 && num9 >= X1 && num10 <= Y1 && num10 >= Y2)
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
}
