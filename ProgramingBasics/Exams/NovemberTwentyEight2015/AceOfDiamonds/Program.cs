using System;

namespace AceOfDiamonds
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			uint n = uint.Parse (Console.ReadLine ());
			for (uint i = 1; i <= n; i++) 
			{
				Console.Write ("*");
			}
			Console.WriteLine ();

			for (uint i = 0; i < (n - 3) / 2; i++) 
			{
				Console.Write ("*");
				for (uint j = 1; j <= ((n - 3) / 2)-i; j++) 
				{
					Console.Write ("-");
				}
				for (uint j = 1; j <= n-(n-1)+i*2; j++) 
				{
					Console.Write ("@");
				}				
				for (uint j = 1; j <= ((n - 3) / 2)-i; j++) 
				{
					Console.Write ("-");
				}
				Console.Write ("*");
				Console.WriteLine ();

			}
			Console.Write ("*");
			for (uint i = 1; i <= n - 2; i++) 
			{
				Console.Write ("@");
			}
			Console.Write ("*");
			Console.WriteLine ();


			for (uint i = 0; i < (n - 3) / 2; i++) 
			{
				Console.Write ("*");
				for (uint j = 1; j <= (n-(n-1))+i; j++) 
				{
					Console.Write ("-");
				}
				for (uint j =  (n-2)-2-i*2;j>=1;j--) 
				{
					Console.Write ("@");
				}				
				for (uint j = 1; j <= (n-(n-1))+i; j++) 
				{
					Console.Write ("-");
				}
				Console.Write ("*");
				Console.WriteLine ();

			}

			for (uint i = 1; i <= n; i++) 
			{
				Console.Write ("*");
			}
			Console.WriteLine ();

		}
	}
}
