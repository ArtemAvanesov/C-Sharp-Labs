using System;

namespace ConsoleApplication1
{
    class Counter
    {
        private int Data; // Поле

        public Counter(int p) // Конструктор
        {
            Data = p;
            if (!Limit_Data())
                throw new Exception("Выход за границу исходных данных!");
        }
        public Counter() // Конструктор
        {
            Data = 5;
        }
        public int get_num
        {
            get
            { return Data; }
        }
        public int Cutting() // Метод - Уменьшение
        {
            if (!Limit_Left())
                Data--;
            else throw new Exception("Выход за границу слева!");
            return Data;
        }
        public int Addition() // Метод - Увеличение
        {
            if (!Limit_Right())
                Data++;
            else throw new Exception("Выход за границу справа!");
            return Data;
        }
        private bool Limit_Data() // Выход за границу исходных данных
        {
            return Data >= 0 && Data <= 10;
        }
        private bool Limit_Left() // Выход за границу при расчетах слева
        {
            return Data == 0;
        }
        private bool Limit_Right() // Выход за границу при расчетах справа
        {
            return Data == 10;
        }

    }
}
