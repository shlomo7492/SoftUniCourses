using System;
using System.Reflection;

namespace DefineClassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            var personOne = new Person() { Name = "Pesho", Age=31};
            var personTwo = new Person() { Name = "Pesho", Age = 31 };

            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
    public class Person
    {
        public string _name;
        public int _age;
        public string Name { get; set; }
        public int Age { get; set; }

    }

}
