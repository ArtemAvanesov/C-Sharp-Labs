
namespace ConsoleApplication1
{

    struct Student
    {
        public string Фамилия;
        public string Имя;
        public string Отчество;
        public string Номер_группы;
        public int[] Успеваемость;

        public Student(string Фамилия, string Имя, string Отчество, string Номер_группы, int[] Успеваемость)
        {

            this.Фамилия = Фамилия;
            this.Имя = Имя;
            this.Отчество = Отчество;
            this.Номер_группы = Номер_группы;
            this.Успеваемость = Успеваемость;

        }


    }
}
