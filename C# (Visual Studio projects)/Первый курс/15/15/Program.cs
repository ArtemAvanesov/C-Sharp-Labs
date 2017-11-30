using System;

namespace ConsoleApplication1
{
    class Program
    {   //Дана длина окружности. Найти площадь круга, ограниченного этой окружностью
        static void Main(string[] args)
        {
            double L;
            Console.WriteLine("Введите значение L");
            L = Convert.ToDouble(Console.ReadLine());
            double S = L * L / (4 * Math.PI);
            if (L >= 0) Console.WriteLine("полученное значение S: " + S);
            else Console.WriteLine("L не может быть отрицательной!");
            Console.ReadKey();
        }
    }
}
