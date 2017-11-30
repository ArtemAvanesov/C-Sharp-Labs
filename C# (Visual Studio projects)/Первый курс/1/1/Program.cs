using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;


            Console.WriteLine("Введите пожалуйста значение X в диапозоне от -9 до 9");
            Console.Write("x= ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x < -9 || x > 9)
                Console.WriteLine("Введены данные, не входящие в диапозон");
            else
            {
                if (x <= -6) y = -Math.Sqrt(9 - (x + 6) * (x + 6));
                else if (x <= -3) y = x + 3;
                else if (x <= 0) y = Math.Sqrt(9 - x * x);
                else if (x <= 3) y = -x + 3;
                else y = x / 2 - 3 / 2;
                Console.WriteLine("y=" + y);

            }

            Console.Read();

            ;
        }
    }
}
