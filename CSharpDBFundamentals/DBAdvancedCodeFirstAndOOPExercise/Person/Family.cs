using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }
        public List<Person> Members
        {
            get
            {
                return this.members;
            }
            set
            {
                //this.member = value;
            }
            
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(m => m.Age).FirstOrDefault();
        }
    }
}
