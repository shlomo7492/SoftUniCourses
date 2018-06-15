using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            for (int i=0;i<inputText.Length;i++)
            {
                text.Append(string.Format("\\u{0:x4}",(int)inputText[i]));
            }
            Console.WriteLine(text);
        }
    }
}
