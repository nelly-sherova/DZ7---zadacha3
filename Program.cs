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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
