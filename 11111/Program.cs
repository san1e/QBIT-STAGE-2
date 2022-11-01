using System;
using System.Linq;

namespace _11111
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = Convert.ToInt32(Console.ReadLine());

            bool diff = val.ToString().Distinct().Count() == val.ToString().Length;

            //Console.WriteLine("Введите число: ");
            //string str = Console.ReadLine();
            //bool diff = str.Distinct().Count() == str.Length;

            Console.WriteLine("Все цифры различные: " + diff);


        }
    }
}
