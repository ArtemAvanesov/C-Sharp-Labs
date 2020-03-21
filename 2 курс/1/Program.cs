using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана целочисленная прямоугольная матрица. Определить:
            //• количество строк, не содержащих ни одного нулевого элемента;
            //• максимальное из чисел, встречающихся в заданной матрице более одного раза.

            int nullstroka = 0, k = 0, max=0;
            bool d  = false; // для фиксации нахождения максимального элемента
            Console.Write("Введите количество строк: n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: m = ");
            int m = Convert.ToInt32(Console.ReadLine());
           
            int[,] b = new int[n,m];
            int[] a = new int[n*m];
           
            for (int i = 0; i < n; i++)
            {  bool s = false; // для фиксации строки с нулевым элементом
                for (int j = 0; j < m; j++)
                {
                 Console.Write("a[" + i + "," + j + "] = "); 
                 b[i,j] = Convert.ToInt32(Console.ReadLine()); 
                 a[k] = b[i, j]; k++;
                 if (b[i,j] == 0 && !s)
                 { nullstroka++; s = true; } // подсчет строк с нулевыми элементами
                } 
            }
            Array.Sort(a);

            for (int i = 0; i < n; i++)
                for (int p = 0; p < m; p++) 
                {
                    int _max;
                    for (int j = n - 1; j > i; j--)
                        for (int t = m - 1; t > p; t--) 
                    {
                        if (b[j,t] < b[j,t-1])
                        {
                                _max = b[j, t];
                                b[j, t] = b[j, t - 1];
                                b[j, t - 1] = _max;
                        }
                    }
                    Console.WriteLine("a[" + i + "]= " + a[i]);
                }
            for (int j = n*m - 1; j >0&&!d ; j--)
            if (a[j] == a[j - 1])
            { d = true; max = a[j]; }
                   
         
            Console.WriteLine("Количество строк, не содержащих ни одного нулевого элемента: "+(n-nullstroka));
            if (d) Console.WriteLine("Максимальное из чисел, встречающихся в заданной матрице более одного раза: " + max );
            else Console.WriteLine("Нет повторяющихся чисел!");
           
            Console.ReadLine();
        }
    }
}
