using System;

namespace DetectiveBoev
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string secretWord = Console.ReadLine ();
			string message = Console.ReadLine ();
			int key = 0;
			foreach (char symb in secretWord) 
			{
				key += symb;
			}
			while (key > 10) 
			{
				secretWord = "";
				secretWord += key;
				key = 0;
				foreach (char symb in secretWord) 
				{
					string digit = "" + symb;
					key += int.Parse (digit);
				}
			}
			char[] word = new char[message.Length];
			for (int i = 0; i <= message.Length - 1; i++) 
			{
				if (message [i] % key == 0)
				{
					word[i] = (char)(message [i] + key);
				} 
				else 
				{
					word[i] = (char)(message [i] - key);
				}
			}
			for (int i = word.Length - 1; i >= 0; i--) 
			{
				Console.Write (word [i]);
			}
		}
	}
}
