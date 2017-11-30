using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        ///Вариант 3
        ///Описать структуру с именем STUDENT, содержащую следующие поля:
        ///• фамилия и инициалы;
        ///• номер группы;
        ///• успеваемость (массив из пяти элементов).
        ///Написать программу, выполняющую следующие действия:
        ///• ввод с клавиатуры данных в массив, состоящий из десяти структур типа STUDENT
        ///(записи должны быть упорядочены по алфавиту);
        ///• вывод на экран фамилий и номеров групп для всех студентов, имеющих хотя бы
        ///одну оценку 2 (если таких студентов нет, вывести соответствующее сообщение).

        static void Main(string[] args)
        {
            List<Student> Список_студентов = new List<Student>();
            Student[] Студент = new Student[2];
            for (int i = 0; i < 2; i++)
            {

                Console.Write("Введите фамилию студента: ");
                Студент[i].Фамилия = Convert.ToString(Console.ReadLine());
                Console.Write("Введите имя студента: ");
                Студент[i].Имя = Convert.ToString(Console.ReadLine());
                Console.Write("Введите отчество студента: ");
                Студент[i].Отчество = Convert.ToString(Console.ReadLine());
                Console.Write("Введите номер группы студента: ");
                Студент[i].Номер_группы = Convert.ToString(Console.ReadLine());
                Console.Write("Введите оценку по ТФКП: ");
                Студент[i].Успеваемость = new int[5];
                Студент[i].Успеваемость[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите оценку по математической статистике: ");
                Студент[i].Успеваемость[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите оценку по иностранному языку: ");
                Студент[i].Успеваемость[2] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите оценку по теоретической механике: ");
                Студент[i].Успеваемость[3] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите оценку по программированию: ");
                Студент[i].Успеваемость[4] = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine(Студент[0].Фамилия);
            Console.WriteLine(Студент[1].Фамилия);


            Console.ReadKey();
        }
    }
}
