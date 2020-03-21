using System;

namespace ConsoleApplication1
{
    class Program
    {//Соревнования по фигурному катанию судят 7 судей. При выведении единой оценки за выступление спортсмена не учитываются наиболее 
     //низкая и наиболее высокая оценки, а для оставшихся вычисляется среднее арифметическое. Определите эту единую оценку. 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите пожалуйста оценки судей:");
            int x = Convert.ToInt16(Console.ReadLine());
            int max = x, min = x, sum = x; 
            for (int i = 0; i <= 5; i++)
            
            {   x = Convert.ToInt16(Console.ReadLine());

                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
                sum += x;
            }

                Console.WriteLine("Общая оценка:" + (sum-min-max)/5);
    
            Console.Read();
        }
    }
}