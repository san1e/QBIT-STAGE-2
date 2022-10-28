﻿using System;

namespace Нерiвнiсть_трикутника
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double a = double.Parse(data[0]);
            double b = double.Parse(data[1]);
            double c = double.Parse(data[2]);
            double p = (a + b + c) / 2;
            double area = (double)Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            if (a+b>c && a+c>b && b+c>a)
            {
                Console.WriteLine(area);
            }
            else
            {
                Console.WriteLine(a+b+c);
            }
        }
    }
}
