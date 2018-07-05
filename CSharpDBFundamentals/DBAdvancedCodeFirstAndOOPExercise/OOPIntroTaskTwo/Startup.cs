using Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroTaskTwo
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Person's name and age:");
            char[] spliter = new char[] { ',' };
            string[] personData = Console.ReadLine()
                                .Split(spliter, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            int input = personData.Length;
            switch (input)
            {
                case 0:
                    {
                        Console.WriteLine(PrintPersonNoArgument());
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine(PrintPersonOneArgument(personData[0]));
                    }
                    break;
                case 2:
                    {
                        string name = personData[0];
                        int age = int.Parse(personData[1]);
                        Console.WriteLine(PrintPersonAllArguments(name,age));
                    }
                    break;
                default:break;
            }
        }
        static string PrintPersonNoArgument()
        {
            Person person = new Person();

            return person.Name + " " + person.Age;
        }

        static string PrintPersonOneArgument(string arg)
        {
            int property = 0;
            Person person = new Person();
            if (int.TryParse(arg, out property))
            {
                person.Age = property;
            }
            else
            {
                person.Name = arg;
            }
            return person.Name + " " + person.Age;
        }
        static string PrintPersonAllArguments(string name, int age)
        {
            Person person = new Person(name,age);
            return person.Name + " " + person.Age;
        }
    }
}
