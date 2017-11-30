using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        { //Для десяти выстрелов, координаты которых задаются с клавиатуры, вывести текстовые сообщения о попадании в мишень 
          //из задания 2 лабораторной работы 2.
            double x,y,R;
            Console.Write("Введите пожалуйста значение R=");
            R = Convert.ToDouble(Console.ReadLine());
            if (R > 0)
            {
                for (int i=0;i<10 ; i++)
                {
                    Console.Write("Введите пожалуйста значение X=");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите пожалуйста значение Y=");
                    y = Convert.ToDouble(Console.ReadLine());

                    if (x * x + y * y <= R * R && ((x >= 0 && y >= x) || (x <= 0 && y <= x)))
                        Console.WriteLine("В яблочко!");
                    else Console.WriteLine("Мимо!");
                }
            }

                else Console.WriteLine("Введено недопустимое значение. R должно быть больше 0");
                Console.Read();
        }
    }
}
