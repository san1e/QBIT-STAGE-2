using System;

namespace Не_виконується_рiвно_одна_з_умов
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            bool Zero1 = num1 < 0;
            bool Zero2 = num2 < 0;
            bool Zero3 = num3 < 0;
            bool Zero4 = num4 < 0;
            bool Zero5 = num5 < 0;
            bool witchNum1 = (num1 / 10 != 0 && num1 / 10 % 10 == 0);
            bool witchNum2 = (num2 / 10 != 0 && num2 / 10 % 10 == 0);
            bool witchNum3 = (num3 / 10 != 0 && num3 / 10 % 10 == 0);
            bool witchNum4 = (num4 / 10 != 0 && num4 / 10 % 10 == 0);
            bool witchNum5 = (num5 / 10 != 0 && num5 / 10 % 10 == 0);
            bool multiply1 = (num1 % 3 != 0 && num1 % 5 != 0);
            bool multiply2 = (num2 % 3 != 0 && num2 % 5 != 0);
            bool multiply3 = (num3 % 3 != 0 && num3 % 5 != 0);
            bool multiply4 = (num4 % 3 != 0 && num4 % 5 != 0);
            bool multiply5 = (num5 % 3 != 0 && num5 % 5 != 0);
            if (Zero1 == false && witchNum1 == true && multiply1 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero1 == true && witchNum1 == false && multiply1 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero1 == true && witchNum1 == true && multiply1 == false)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Zero2 == false && witchNum2 == true && multiply2 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero2 == true && witchNum2 == false && multiply2 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero2 == true && witchNum2 == true && multiply2 == false)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Zero3 == false && witchNum3 == true && multiply3 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero3 == true && witchNum3 == false && multiply3 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero3 == true && witchNum3 == true && multiply3 == false)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Zero4 == false && witchNum4 == true && multiply4 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero4 == true && witchNum4 == false && multiply4 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero4 == true && witchNum4 == true && multiply4 == false)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Zero5 == false && witchNum5 == true && multiply5 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero5 == true && witchNum5 == false && multiply5 == true)
            {
                Console.WriteLine("YES");
            }
            else if (Zero5 == true && witchNum5 == true && multiply5 == false)
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
