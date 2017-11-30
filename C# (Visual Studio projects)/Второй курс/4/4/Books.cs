using System;

namespace ConsoleApplication1
{

    class Books
    {
        static int n = 3;
        public string[][] Base = new string[n][]; // База на 3 книги
        public int Number;
        private bool f = false;
        public String this[int i, int j]
        {
            get { return Base[i][j]; }
            set
            {
                if (j == 0)
                {
                    Number = i + 1;
                    Base[i] = new string[4];
                }
                Base[i][j] = value;

            }
        }

        public void Library() // Библиотека
        {
            for (int i = 0; i < Number; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 4; j++)
                    Console.Write(Base[i][j] + " ");
                Console.WriteLine("");

            }
        }
        public void Delete(int s) // Удаление книг
        {
            if (s == n - 1)
                Base[s] = null;
            else
            {
                for (int i = s + 1; i < Number; i++)
                    for (int j = 0; j < 4; j++)
                        Base[i - 1][j] = Base[i][j];

                Base[Number - 1] = null;
            }
            Number--;
        }

        public void Search(int answer, string поиск) // Поиск книг
        {

            if (answer == 5)
            {
                for (int k = 0; k < 4; k++)
                    Console.Write(Base[Convert.ToUInt16(поиск)][k] + " ");

                f = true;
            }
            else
                for (int i = 0; i < Number; i++)
                {
                    if (поиск == Base[i][answer - 1])
                    {
                        for (int k = 0; k < 4; k++)
                            Console.Write(Base[i][k] + " ");
                        f = true;
                    }
                }
            if (f == false)
                Console.Write("Поиск не дал результатов!!! ");
            Console.WriteLine();
        }

    }
}
