using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegiteble
{
    class FrutOrVegie
    {
        static void Main(string[] args)
        {
            var enteredValue = Console.ReadLine();
            switch (enteredValue)
            { 
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes": Console.WriteLine("fruit"); break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot": Console.WriteLine("vegetable"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
