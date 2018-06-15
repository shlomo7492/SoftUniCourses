using System;

namespace Greetings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string name = Console.ReadLine ();
			string surname = Console.ReadLine ();
			int age = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Hello, {0} {1}. You are {2} years old.",name,surname,age);
				
		}
	}
}
