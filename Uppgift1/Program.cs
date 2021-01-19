using System;
using System.Collections.Generic;

namespace Uppgift1
{
    class Person
    {
        public string Name { get; set; }
        public ulong Salary { get; set; }
        public Person(string name, ulong salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public Person()
        {
            Salary = 0;
        }
    }
    class Register
    {
        private List<Person> list;
        public Register()
        {
            list = new List<Person>();
        }
        public bool Add(Person person)
        {
            if (String.IsNullOrEmpty(person.Name) == false && person.Salary != 0)
            {
                list.Add(person);
                return true;
            }
            else
                return false;
        }
        public void Add(string name, ulong salary)
        {
            list.Add(new Person(name,salary));
        }
        public void Print()
        {
            Console.WriteLine("Anställda:");
            foreach(Person person in list)
            {
                Console.WriteLine("  {0}: {1} kr", person.Name, person.Salary);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register();
            register.Add("Nisse", 10000);
            register.Add("Bertil", 12000);

            Person kalle = new Person();
            kalle.Name = "Kalle";
            //kalle.Salary = 8000;
            Person maja = new Person();
            maja.Name = "Maja";
            maja.Salary = 15000;

            register.Add(kalle);
            register.Add(maja);
            register.Print();
        }
    }
}
