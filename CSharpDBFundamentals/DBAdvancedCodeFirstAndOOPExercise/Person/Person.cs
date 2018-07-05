using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        //Task One: Creating class Person with properties Name and Age
        public string Name { set; get; }
        public int Age { set; get; }
        //Task Two: Creating four constructors for the Person class
      
        public Person():this("No name",1)
        { }
        public Person(int age) : this("No name", age)
        { }
        public Person(string name) : this(name, 1)
        { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
