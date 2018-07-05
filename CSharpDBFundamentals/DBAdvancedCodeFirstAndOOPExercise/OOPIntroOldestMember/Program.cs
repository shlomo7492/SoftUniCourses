using Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroOldestMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            Console.Write("Enter the number of Family members: ");
            int numMembers = int.Parse(Console.ReadLine());
            char[] spliter = new char[] { ' ' };

            for (int i = 0; i < numMembers; i++)
            {
                string[] member = Console.ReadLine().Split(spliter, StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                family.AddMember(new Person(member[0],int.Parse(member[1])));  
            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
