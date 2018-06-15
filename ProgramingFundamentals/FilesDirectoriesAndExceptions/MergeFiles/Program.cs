using System;
using System.IO;
using System.Collections.Generic;

namespace MergeFiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] fileOne = File.ReadAllLines ("../FileOne.txt");
			string[] fileTwo = File.ReadAllLines ("../FileTwo.txt");
			List<string> mergedColections = new List<string> ();
			for (int i = 0; i < fileOne.Length; i++) 
			{
				mergedColections.Add (fileOne [i]);
				mergedColections.Add (fileTwo [i]);
			}
			File.AppendAllLines ("../output.txt", mergedColections);

		}
	}
}
