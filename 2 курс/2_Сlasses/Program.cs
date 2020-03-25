using System;

namespace ConsoleApplication1
{
    class Program
    {   /// <summary>
        /// Вариант 1
        ///Описать класс, реализующий десятичный счетчик, который может увеличивать
        ///или уменьшать свое значение на единицу в заданном диапазоне.Предусмотреть
        ///инициализацию счетчика значениями по умолчанию и произвольными значениями.
        ///Счетчик имеет два метода: увеличения и уменьшения, — и свойство, позволяющее
        ///получить его текущее состояние.При выходе за границы диапазона
        ///выбрасываются исключения.
        ///Написать программу, демонстрирующую все разработанные элементы класса.
        /// </summary>
 
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная №2";

            Counter Data_1 = new Counter();
            Console.WriteLine("Исходное значение: " + Data_1.get_num);
            Console.WriteLine("Демонстрация метода уменьшения: ");
            Console.WriteLine(Data_1.Cutting());
            Console.WriteLine("Демонстрация метода увеличения: ");
            Console.WriteLine(Data_1.Addition());

            Counter Data_2 = new Counter(10);
            Console.WriteLine("Исходное значение: " + Data_2.get_num);
            Console.WriteLine("Демонстрация метода увеличения: ");
            try
            { Console.WriteLine(Data_2.Addition()); }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Counter Data_3 = new Counter(0);
            Console.WriteLine("Исходное значение: " + Data_3.get_num);
            Console.WriteLine("Демонстрация метода уменьшения: ");
            try
            { Console.WriteLine(Data_3.Cutting()); }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Console.WriteLine("Исходное значение: " + 100);
            try
            { Counter Data_4 = new Counter(100); }
            catch (Exception e) { Console.WriteLine(e.Message); }


            Console.Write("\nНажмите любую клавишу чтобы закончить работу в програме:");
            Console.Read();
        }
    }
}
