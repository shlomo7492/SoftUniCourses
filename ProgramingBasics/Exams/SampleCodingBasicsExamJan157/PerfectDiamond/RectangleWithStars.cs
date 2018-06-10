using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string spaces = new string(' ', 2 * n - 2); 
            string smallSpaces = new string(' ', n - 2);
            string firstAndEnd = new string('%', 2 * n );
            Console.WriteLine(firstAndEnd);
            if (n % 2 == 0) //even
            {
                for (int i = 1; i <= (n - 1); i++)
                {
                    if ((((n - 1) / 2) + 1) == i)
                    {
                        Console.WriteLine("%"+smallSpaces+"**"+smallSpaces+"%");
                    }
                    else 
                    {
                        Console.WriteLine("%" + spaces + "%");
                    }
                }
            }
            else //odd
            {
                for (int i = 1; i <= n ; i++)
                {
                    if (((n / 2) + 1) == i)
                    {
                        Console.WriteLine("%" + smallSpaces + "**" + smallSpaces + "%");
                    }
                    else
                    {
                        Console.WriteLine("%" + spaces + "%");
                    }
                }
            }
            Console.WriteLine(firstAndEnd);
            Console.ReadKey();
        }
    }
}
