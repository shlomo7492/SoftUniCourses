using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                if (emails.ContainsKey(name))
                {
                    emails[name] += email;
                }
                else if((email.Substring(email.Length-2,2).ToLower() !="us")
                    || (email.Substring(email.Length - 2, 2).ToLower() != "uk"))
                {
                    emails.Add(name, email);
                }
            }
            foreach (KeyValuePair<string, string> email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
   
}
