using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            Console.WriteLine("Введите пожалуйста значение R");
            Console.Write("R= ");
            R = Convert.ToDouble(Console.ReadLine());
            if (R <= 0) Console.WriteLine("Введено недопустимое значение. R должно быть больше 0");
            else
            {
                double x;
                Console.WriteLine("Введите пожалуйста значение X");
                Console.Write("x= ");
                x = Convert.ToDouble(Console.ReadLine());
                double y;
                Console.WriteLine("Введите пожалуйста значение Y");
                Console.Write("y= ");
                y = Convert.ToDouble(Console.ReadLine());
                if (x * x + y * y <= R * R && ((x >= 0 && y >= x) || (x <= 0 && y <= x)))
                    Console.WriteLine("В яблочко!");
                else Console.WriteLine("Мимо!");
                Console.Read();
            }
        }
    }
}
