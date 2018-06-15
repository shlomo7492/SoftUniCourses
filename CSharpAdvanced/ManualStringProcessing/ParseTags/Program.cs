using System;
using System.Collections.Generic;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string startTag = "<upcase>"; 
            string endTag = "</upcase>";

            Queue<string> textQueue = new Queue<string>();
            
            while (text.IndexOf(startTag)>-1)
            {
                if (text.IndexOf(startTag) > 0)
                {
                    textQueue.Enqueue(text.Substring(0, text.IndexOf(startTag)));
                    text = text.Substring(text.IndexOf(startTag), text.Length - text.IndexOf(startTag));
                }
                else if (text.IndexOf(startTag) == 0)
                {
                    textQueue.Enqueue(text.Substring(startTag.Length, text.IndexOf(endTag) - startTag.Length).ToUpper());
                    text = text.Substring(text.IndexOf(endTag) + endTag.Length, text.Length - (text.IndexOf(endTag) + endTag.Length));
                }
            }
            if (text.Length != 0)
            {
                textQueue.Enqueue(text);
            }
            Console.WriteLine(String.Join("",textQueue));
            
        }
    }
}
