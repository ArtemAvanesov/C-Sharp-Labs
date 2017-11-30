using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("z = cos(a) + sin(a) + cos(3a) + sin(3a)");
            Console.WriteLine("Введите значение a:");
            a = Convert.ToDouble(Console.ReadLine());
            double Z = Math.Cos(a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);
            Console.WriteLine("полученное значение Z: " + Z);
            Console.ReadKey();
        }
    }
}
