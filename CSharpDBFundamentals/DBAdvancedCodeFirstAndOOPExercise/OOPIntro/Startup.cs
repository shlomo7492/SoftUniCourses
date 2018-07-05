using Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Startup
    {
        static void Main(string[] args)
        {
            //Creating persons
            Person pesho = new Person()
            {
                //Initializing pesho
                Name = "Pesho",
                Age = 20
            };
            Person tosho = new Person();
            Person stamat = new Person();
           
            // Initializing tosho's, and stamat's properties
            tosho.Name = "Tosho";
            tosho.Age = 18;
            stamat.Name = "Stamat";
            stamat.Age = 43;
           
            //Printing Name and Age::
            PrintPerson(pesho.Name, pesho.Age);
            PrintPerson(tosho.Name, tosho.Age);
            PrintPerson(stamat.Name, stamat.Age);
        }
        static void PrintPerson(string name, int age)
        {
            Console.WriteLine($"{name} is {age} years old.");
        }
       
    }
}
