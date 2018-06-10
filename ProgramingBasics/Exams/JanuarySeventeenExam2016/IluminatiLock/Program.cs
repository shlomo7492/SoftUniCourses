using System;

namespace IluminatiLock
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			Console.WriteLine ((new string('.',n))+(new string('#',n))+(new string('.',n)));
			for (int i = 1; i <= n / 2; i++) 
			{
				Console.WriteLine ((new string('.',n-i*2))+"##"+(new string('.',(i-1)*2))+"#"+(new string('.',n-2))+"#"+(new string('.',(i-1)*2))+"##"+(new string('.',n-i*2)));
			}
			for (int i =  n / 2; i >= 1; i--) 
			{
				Console.WriteLine ((new string('.',n-i*2))+"##"+(new string('.',(i-1)*2))+"#"+(new string('.',n-2))+"#"+(new string('.',(i-1)*2))+"##"+(new string('.',n-i*2)));
			}
			Console.WriteLine ((new string('.',n))+(new string('#',n))+(new string('.',n)));
		}
	}
}
