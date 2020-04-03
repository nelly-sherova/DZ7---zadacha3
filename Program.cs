using System;

namespace Studentt
{
    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string middleName { get; set; }
        public char group { get; set; }
        public int estimation1 { get ; set; }
        public int estimation2 { get; set ; }
        public int estimation3 { get; set; }   
            public Student(string name, string surname, string middleName, char group, int estimation1, int estimation2, int estimation3)
        {
            this.name = name;
            this.surname = surname;
            this.middleName = middleName;
            this.group = group;
            this.estimation1= estimation1;
            this.estimation2 = estimation2;
            this.estimation3 = estimation3;

        }
        public double Sredball()
        { 
            return ((double)(estimation1+estimation2+estimation3)/3);
        }
        public void Info()
        {
            Console.WriteLine($"{name}, {surname}, {middleName}");
            Console.WriteLine($"Group: {group}");
            Console.WriteLine($"Оценки: {estimation1}, {estimation2}, {estimation3} ");
            Console.WriteLine($"Средний балл: {Sredball()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = {"Нилуфар", "Рустам", "Сабрина", "Мухаммад", "Комил","Нигина"};
            string[] surname = {"Шерова", "Баротов", "Хикматова", "Норов", "Низомов", "Тошева"};
            string[] middleName = {"Умеджоновна", "Окилович", "Олимовна", "Каромович", "Толибовна"};
            char[] group = {'a', 'b', 'a', 'b', 'c', 'c'};
            int[] estimation1 = {5, 4, 3, 4, 3, 4};
            int[] estimation2 = {5, 5, 4, 5, 4, 3};
            int[] estimation3 = {5, 4, 4, 4, 4, 4};
            for(int i=0; i<name.Length; i++)
            {
                Student student = new Student(name[i], surname[i], middleName[i], group[i], estimation1[i], estimation2[i], estimation3[i]);
                student.Info();
            }
            /* Вся сложность решения дз была в том, что:
            1. get и set не очень понятны
            2. использование нескольких классов и взаимодействие между ними
            Спасибо
            */
        }
    }
}
