using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for(int i=0;i<n;i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                persons.Add(new Person(input[0], int.Parse(input[1])));
            }
            foreach (var person in persons.Where(p => p.Age > 30).OrderBy(p=>p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            } 
        }
        public class Person
        {
            public string name;
            public int age;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    this.name = value;
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    this.age = value;
                }
            }
            public Person()
            {
                this.name = "No name";
                this.age = 1;
            }
            public Person(int age)
            {
                this.name = "No name";
                this.age = age;
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
