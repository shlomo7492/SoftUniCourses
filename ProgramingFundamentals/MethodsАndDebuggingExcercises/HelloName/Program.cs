using System;

namespace HelloName
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string name = Console.ReadLine ();
			PrintGreeting (name);
		}
		static void PrintGreeting (string name)
		{
			Console.WriteLine ("Hello, {0}!", name);
		}
	}
}
