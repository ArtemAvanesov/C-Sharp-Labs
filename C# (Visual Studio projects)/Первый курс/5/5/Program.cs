using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {   //Дана последовательность из 10 целых чисел. 
            //Определить, со скольких отрицательных чисел она начинается. 

            Console.WriteLine("Введите последовательность:");
            int x;
            int number = -1;
            bool t = true;

            for (int i = 0; i < 10; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (t) number++;
                if (x >= 0) t = false;
            }

            Console.WriteLine("Количество отрицательных чисел, с которых начинается последовательность: " + number);

            Console.Read();
        }
    }
}
