using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> testAccounts = new List<BankAccount>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "End")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Create":
                        {
                            if (testAccounts.Where(acc => acc.ID == int.Parse(command[1])).SingleOrDefault() != null)
                            {
                                Console.WriteLine("Account already exists");
                            }
                            else
                            {
                                testAccounts.Add(new BankAccount() { ID = int.Parse(command[1]) });
                            }
                        }
                        break;
                    case "Deposit":
                        {
                            if (testAccounts.Select(acc => acc.ID == int.Parse(command[1])) == null)
                            {
                                Console.WriteLine("Account does not exists");
                            }
                            testAccounts.Where(acc => acc.ID == int.Parse(command[1]))
                                        .Single()
                                        .Deposit(double.Parse(command[2]));
                        }
                        break;
                    case "Withdraw":
                        {
                            if (testAccounts.Select(acc => acc.ID == int.Parse(command[1])) == null)
                            {
                                Console.WriteLine("Account does not exists");
                            }
                            else if (testAccounts.Where(acc => acc.ID == int.Parse(command[1])).SingleOrDefault().Balance < double.Parse(command[2]))
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else
                            {
                                testAccounts.Where(acc => acc.ID == int.Parse(command[1]))
                                     .SingleOrDefault()
                                     .Withdraw(double.Parse(command[2]));
                            }
                        }
                        break;
                    case "Print":
                        {
                            if (testAccounts.Select(acc => acc.ID == int.Parse(command[1])) == null)
                            {
                                Console.WriteLine("Account does not exists");
                            }
                            else
                            {
                                Console.WriteLine(testAccounts.Where(acc => acc.ID == int.Parse(command[1]))
                                    .SingleOrDefault().ToString());
                            }

                        }
                        break;

                    default: break;
                }
            }
        }
    }
}
