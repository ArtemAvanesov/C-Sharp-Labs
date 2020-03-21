using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {//Даны два целых числа A и B (A < B). Вывести все целые числа от A до B включительно 
         //в порядке их возрастания, а также количество N этих чисел. 

            Console.WriteLine("Введите пожалуйста значение A");
            Console.Write("A= ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пожалуйста значение B (B>A)");
            Console.Write("B= ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A < B)
            {
                int n = B - A + 1;
                Console.WriteLine("Количество чисел: " + n);
                for (int C = A; C <= B; ++C)
                    Console.WriteLine(C);

            }
            else
                Console.WriteLine("Введены неверные данные!");

            Console.Read();

        }
    }
}
