using System;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {   //Написать программу, которая считывает из текстового файла три предложения
            //и выводит их в обратном порядке.

            try
            {
                StreamReader sr = new StreamReader("Строки.txt", Encoding.Default);
                String a = sr.ReadToEnd();
                sr.Close();

                Console.WriteLine(a);
                a = a + " ";
                string b = "";

                for (int j = 0; j < a.Length; j++)
                {
                    b += a[j];
                    if ((a[j] == '!' || a[j] == '.' || a[j] == '?') && j != a.Length - 1 && a[j + 1] != '!' && a[j + 1] != '.')
                    {
                        b += "#";
                    }
                }
                string[] text = b.Split(new string[] { "# " }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = text.Length - 1; j >= 0; j--)
                {
                    if (j != 0) Console.Write(text[j] + " ");
                    else Console.Write(text[j]);
                }

            }

            catch (IOException e) { Console.WriteLine(e.Message); }
            catch { Console.WriteLine("Неопозднаное исключение!"); }
            Console.Read();
        }
    }
}
