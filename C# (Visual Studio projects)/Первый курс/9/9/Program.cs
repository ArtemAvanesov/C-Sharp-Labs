      using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить и вывести на экран в виде таблицы значения функции, заданной с помощью ряда Тейлора, на интервале от Xнач до 
            //Xкон с шагом dx с точностью ε. Таблицу снабдить заголовком и шапкой. Каждая строка таблицы должна содержать значение 
            //аргумента, значение функции и количество просуммированных членов ряда. y = 2 / (2*n + 1)*x ^ (2*n + 1) , |x|>1 .

            double Xнач, Xкон, dX, E, x, Y, T;
            int n;
            Console.WriteLine("|Xнач|>1     |Xкон|>1      Xкон>Xнач      dX>0      E>0\n");
            Console.Write("Введите пожалуйста значение Xнач:");
            Xнач = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите пожалуйста значение Xкон:");
            Xкон = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите пожалуйста значение dX:");
            dX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите пожалуйста значение E:");
            E = Convert.ToDouble(Console.ReadLine());

           
            if ((Xнач < -1 || Xнач > 1) && (Xкон < -1 || Xкон > 1) && dX > 0 && E>0)
            {     
               

             
               Console.WriteLine("+---------------+---------------+---------------+");
               Console.WriteLine("| {0,7}\t| {1,7}\t| {2,7}\t|","X","    Тейлор","   Функция");
               Console.WriteLine("|---------------|---------------|---------------|");

               for (x = Xнач; x <= Xкон; x += dX)
               {
                   T = 2 / x;
                   Y = T;
                   
                   n = 0;
                   while ( Math.Abs(T) >= E)
                   { T *= (2 * n + 1) /((2*n+3)*x*x); Y += T;n++; }
                  
                  Console.WriteLine("| {0,7}\t| {1,7}\t| {2,7}\t|", Math.Round(x, 2), Math.Round(Y, 10),  
                  Math.Round(Math.Log((x + 1) / (x - 1)), 10));
                }
                Console.WriteLine("+---------------+---------------+---------------+");




             }
              else  Console.WriteLine("Ошибка, проверьте правильность введенных данных!");


    Console.Read();
        }
    }
}
