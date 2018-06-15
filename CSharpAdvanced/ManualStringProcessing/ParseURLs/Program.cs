using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURLs
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string separator = "://";
            string[] urlArr = url.Split(new[] {separator},StringSplitOptions.RemoveEmptyEntries);


            if(urlArr.Length !=2 || urlArr[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
                
            }
            else
            {
                string protocol= urlArr[0];

                int index = urlArr[1].IndexOf('/');

                string server = urlArr[1].Substring(0, index);
                string resources = urlArr[1].Substring(index + 1);

                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources}");
            }
        }
    }
}
