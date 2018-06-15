using System;
using System.Linq;
using System.Collections.Generic;

namespace Files
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// reads the number of files to read
			int inputCount = int.Parse(Console.ReadLine ());
			//readds all files
			File[] collectionOfFiles = GetAllFiles(inputCount);
			//reads and formats the rule
			string[] rule = GetTheRule (Console.ReadLine ());
			//add files that fullfil the rule to List of files
			List<File> files = GetAllFilesByTheRule (collectionOfFiles, rule);
			//returns sorted List of files firs by size, then by name
			if (files != null)
			{
				files = GetSortedFiles (files);
			}
			//print the sorted List of Files
			PrintFiles (files);


		}
		//this works returns single file info
		static File GetFileInfo(string inputLine/*, string root*/)
		{
			File file = new File ();
			string[] strArr = inputLine.Split ('\\');
			/*	foreach (string value in strArr) 
			{
				if (value == root) 
				{*/
				file.Root = strArr[0];
					
				//}
			//}
			file.Size = double.Parse (strArr[strArr.Length-1].Split (';') [1]);
			string[] fileName = strArr [strArr.Length - 1].Split (';') [0].Split ('.');
			file.Name = fileName [0];
			file.Extension = fileName [1];
			return file;
		}
		//this works returns array of files
		static File[] GetAllFiles(int inputCount)
		{
			File[] collectionOfFiles = new File[inputCount];
			for (int i = 0; i < inputCount; i++) 
			{
				string inputLine = Console.ReadLine ();
				collectionOfFiles[i]= GetFileInfo (inputLine);
			}
			return collectionOfFiles;
		}
		//this works return extension and root
		static string[] GetTheRule (string rule)
		{
			string[] rules = rule.Split ();
			return new string[]{ rules[0],rules[2]};
		}

		static List<File> GetAllFilesByTheRule(File[] files,string[] rule)
		{
			bool isNotEmpty = false;
			Dictionary<string,File> ruleIndexedDic = new Dictionary<string, File> ();
			foreach (File file in files) 
			{
				if ((file.Extension == rule[0])&&(file.Root==rule[1]))
				{
					ruleIndexedDic [file.Name] = file;
					isNotEmpty = true;
				}
			}
			if (isNotEmpty) 
			{
				return ruleIndexedDic.Select (x => x.Value).ToList ();
			} 
			else 
			{
				return null;
			}
		}
		static List<File> GetSortedFiles(List<File> files)
		{
			return files.OrderBy(x => x.Size).ThenBy(x=>x.Name).ToList();
		}
		static void PrintFiles (List<File> filesSorted)
		{
			if (filesSorted != null) 
			{
				foreach (File file in filesSorted) {
					Console.WriteLine ($"{file.Name}.{file.Extension} - {file.Size} KB");
				}
			} 
			else 
			{
				Console.WriteLine ("No");
			}
		}
	}
	class File
	{
		public string Name 
		{
			get;
			set;
		}
		public string Extension 
		{
			get;
			set;
		}
		public double Size 
		{
			get;
			set;
		}
		public string Root 
		{
			get;
			set;
		}
	}
}
