using System;

namespace StringsAndObjects
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string hello = "Hello";
			string world = "World";
			object objectVar = hello + " " + world;
			string text = (string)objectVar;
			Console.WriteLine (text);
		}
	}
}
