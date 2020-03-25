using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //В одномерном массиве, состоящем из п вещественных элементов, вычислить:
            //• сумму отрицательных элементов массива;
            //• произведение элементов массива, расположенных между максимальным и минимальным элементами.
            //• Упорядочить элементы массива по возрастанию.

            int min1 = 0, max1 = 0;
            double sum = 0, pr_min_max = 1, m;
            Console.WriteLine("Введите количесиво элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = Convert.ToDouble(Console.ReadLine());
                if (a[i] < 0) sum += a[i];
                if (a[i] < a[min1])
                    min1 = i;
                if (a[i] > a[max1])
                    max1 = i;

            }

            if (Math.Abs(max1 - min1) > 2)
            {
                int k = min1, l = min1;
                if (min1 < max1) l = max1;
                if (min1 > max1) k = max1;
                for (int j = k + 1; j < l; j++) { pr_min_max *= a[j]; }
            }

            Console.WriteLine("____________________________________");
            if (Math.Abs(min1 - max1) <= 2)
                Console.WriteLine("Невозможно вычислить произведение!");
            else
                Console.WriteLine("Произведение: " + pr_min_max);
            Console.WriteLine("____________________________________");

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (a[j] < a[j - 1])
                    {
                        m = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = m;
                    }
                }
                Console.WriteLine("a[" + i + "]= " + a[i]);
            }

            Console.WriteLine("Сумма отрицательных элементов массива: " + sum);

            Console.Read();


        }
    }
}
