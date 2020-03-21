using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("z = 1/4 - sin(5П/2 - 8a)/4");
            Console.WriteLine("Введите значения a: ");
            a = Convert.ToDouble(Console.ReadLine());
            double z = (1 - Math.Sin(5 * Math.PI / 2 - 8 * a)) / 4;
            Console.WriteLine("полученное значение z: " + z);
            Console.ReadKey();

        }
    }
}
