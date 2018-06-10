using System;

namespace VowelsSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var sum = 0;
			var text = Console.ReadLine ().ToLower();
			for (int i = 0; i < text.Length; i++) 
			{
				switch (text [i])
				{
					case 'a':
						sum = sum + 1;
						break;
					case 'e':
						sum = sum + 2;
						break;
					case 'i':
						sum = sum + 3;
						break;
					case 'o':
						sum = sum + 4;
						break;
					case 'u':
						sum = sum + 5;
						break;
					default:
						break;
				}
			}
			Console.WriteLine (sum);
		}
	}
}
