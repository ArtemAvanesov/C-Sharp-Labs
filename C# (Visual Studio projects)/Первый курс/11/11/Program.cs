using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CATCH 
            //Дано целое число N (> 1). Вывести по порядку все нечетные числа, начиная с 1, которые меньше N. 

            Console.WriteLine("Введите пожалуйста значение N ( N>1 ):");
            Console.Write("N= ");
            try
            
            {int N = Convert.ToInt32(Console.ReadLine());
                if (N > 1)
                    {int a = 1;
                    Console.WriteLine("Все нечетные числа: ");
                    while (a < N)
                    { if (a % 2 != 0) Console.WriteLine(a); a++; }}
                else Console.WriteLine("Введены неверные данные!");}

            catch (FormatException e ) { Console.WriteLine(e.Message); }
            catch (OverflowException e) {Console.WriteLine(e.Message);}
            catch { Console.WriteLine("Неопознанное исключение"); } 

            Console.Read();
        }
    }
}
