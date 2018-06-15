using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> undoActions = new Stack<string>();
            string editor = "";
            for (int i=1;i<=n;i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                switch (input[0])
                {
                    case "1":
                        {
                            undoActions.Push(editor);
                            editor += input[1];
                        }
                        break;
                    case "2":
                        {
                            undoActions.Push(editor);
                            editor = editor.Substring(0, editor.Length - int.Parse(input[1]));
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine(editor[int.Parse(input[1])-1]);
                        }
                        break;
                    default:
                        {
                            editor = undoActions.Pop();
                        } break;
                }
            }
        }
    }
}
