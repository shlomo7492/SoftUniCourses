using System;

namespace StopSign
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			Console.WriteLine((new String('.',n+1))+(new String('_',(2*n)+1))+(new String('.',n+1)));
			for (int i = 1; i <= n; i++) 
			{
				Console.WriteLine((new String('.',n-(i-1)))+"//"+(new String('_',(2*n-1)+((i-1)*2)))+"\\\\"+(new String('.',n-(i-1))));
			}
			Console.WriteLine("//"+(new String('_',((4*n+3)-9)/2))+"STOP!"+(new String('_',((4*n+3)-9)/2))+"\\\\");

			for (int i = 0; i < n; i++) 
			{
				Console.WriteLine((new String('.',i))+"\\\\"+(new String('_',(4*n+3)-(2*i+4)))+"//"+(new String('.',i)));
			}
		}
	}
}
