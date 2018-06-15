using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] separators = new char[]{'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '};
			string[] text = Console.ReadLine ().ToLower ()
												.Split (separators,StringSplitOptions.RemoveEmptyEntries);
			text=text.Where (x=>x.Length<5).ToArray ();
			Console.WriteLine (string.Join (", ", text.OrderBy(x=>x).Distinct()));

		}
	}
}
