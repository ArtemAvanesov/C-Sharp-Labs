using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить и вывести на экран в виде таблицы значения функции, заданной графически (см. задание 1 лабораторной работы 2), 
            //на интервале от хнач до хкон с шагом dx. Интервал и шаг задать таким образом, чтобы проверить все ветви программы. 
            //Таблицу снабдить заголовком и шапкой.

            Console.WriteLine("Введите пожалуйста значение dx (dx>0):");
            Console.Write("dx= ");
            double dx = Convert.ToDouble(Console.ReadLine());
            if (dx>0)
            
            {  double y;

            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("._________________.");
            Console.WriteLine("|{0,5} | {1,9}|", "x", "y");
            Console.WriteLine("|------|----------|");
               for (double x = -9; x <= 9; x += dx)
              
               { if (x <= -6) y = -Math.Sqrt(9 - (x + 6) * (x + 6));
               else if (x <= -3) y = x + 3;
               else if (x <= 0) y = Math.Sqrt(9 - x * x);
               else if (x <= 3) y = -x + 3;
               else  y = x / 2 - 1.5;
               Console.WriteLine("|{0,5} | {1,9}|", x, y);

               }
               Console.WriteLine("|______|__________|");
            }
            else
                Console.WriteLine("Введены неверные данные!");

            Console.Read();


        }
    }
}
