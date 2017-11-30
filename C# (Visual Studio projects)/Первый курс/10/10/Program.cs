using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {  //Найти два первых числа Фибоначчи таких, что второе делится нацело на первое. 
          
            Console.WriteLine("Два первых числа Фибоначчи такие, что второе делится нацело на первое:");
            int a = 2;
            int b = 3;
            int c;
         
            while (b % a != 0)
            
              { c = a + b;
                a = b;
                b = c;}

            Console.WriteLine("Первое число:" + a);
            Console.WriteLine("Второе число:" + b);
            Console.Read();
        }
    }
}
