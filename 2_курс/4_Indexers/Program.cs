using System;

namespace ConsoleApplication1
{
    class Program
    {      /* Каждый разрабатываемый класс должен, как правило, содержать следующие элементы:
              скрытые поля, конструкторы с параметрами и без параметров, методы;
              свойства, индексаторы; перегруженные операции. Функциональные элементы класса
              должны обеспечивать непротиворечивый, полный, минимальный и удобный интерфейс
              класса. При возникновении ошибок должны выбрасываться исключения.
              В программе должна выполняться проверка всех разработанных элементов класса.
            - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            Описать класс «домашняя библиотека». Предусмотреть возможность работы
            с произвольным числом книг, поиска книги по какому-либо признаку (по автору, по году издания или категории), 
            добавления книг в библиотеку, удаления
            книг из нее, доступа к книге по номеру.
            Написать программу, демонстрирующую все разработанные элементы класса.*/

        static void Main(string[] args)
        {
            Books Книга = new Books();

            Книга[0, 0] = "Программирование на языке высокого уровня";
            Книга[0, 1] = "2007 год";
            Книга[0, 2] = "Павловская Т.А.";
            Книга[0, 3] = "Азбука";
            Книга[1, 0] = "Пингвинчик";
            Книга[1, 1] = "1337";
            Книга[1, 2] = "Австралия";
            Книга[1, 3] = "Черно-белое";

            Console.WriteLine("Демонстрация добавления книг:");
            Console.Write("Введите название книги: ");
            try
            {
                Книга[2, 0] = Convert.ToString(Console.ReadLine());
                Console.Write("Введите год издания книги: ");
                Книга[2, 1] = Convert.ToString(Console.ReadLine());
                Console.Write("Введите автора книги: ");
                Книга[2, 2] = Convert.ToString(Console.ReadLine());
                Console.Write("Введите категорию книги: ");
                Книга[2, 3] = Convert.ToString(Console.ReadLine());
            }
            catch (FormatException e) { Console.WriteLine(e.Message); }

            Console.WriteLine("Демонстрация вывода базы книг:");
            Книга.Library();

            Console.WriteLine("Демонстрация поиска книг:");
            Console.Write("Введите признак, по которому будет осуществляться поиск:\nНазвание - 1, Год издания - 2, Автор - 3, Категория - 4, Номер - 5\nОтвет: ");
            try
            {
                int answer = Convert.ToUInt16(Console.ReadLine());
                Console.Write("Введите данные для поиска: ");
                string поиск = Convert.ToString(Console.ReadLine());
                Книга.Search(answer, поиск);
            }
            catch (FormatException e) { Console.WriteLine(e.Message); }
            Console.WriteLine("Демонстрация удаления книг:");
            Console.Write("Введите номер книги, которую хотите удалить: ");
            try
            {
                int number = Convert.ToUInt16(Console.ReadLine());
                Книга.Delete(number);
            }
            catch (FormatException e) { Console.WriteLine(e.Message); }
            Console.WriteLine();
            Книга.Library();
            Console.Read();
        }
    }
}
