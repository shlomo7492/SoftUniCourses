using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i=0;i<n;i++)
            {
                string[] inputMember = Console.ReadLine().Split(' ');
                Person person = new Person(inputMember[0], int.Parse(inputMember[1]));
                family.AddMember(person);
            }
            Person oldestFamilyMember = family.GetOldestMember();
            Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
        }
    }
}
