using System;

namespace Наследование1
{
    class Person 
    {
        string name;
        int age;

        public Person(string name) 
        { 
        this.name = name;
            Console.WriteLine("Person(string name)");
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("Person(string name, int age)");
        }
    }

    class Employy : Person 
    {
        string company;

        public Employy(string name, int age, string company): base(name, age) 
        {
            this.company = company;
            Console.WriteLine("Employy(string name, int age, string company)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Employy e = new Employy("Андерсон", 25, "Матрица");
            Console.ReadKey();
        }
    }
}
