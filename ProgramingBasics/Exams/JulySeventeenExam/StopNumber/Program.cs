using System;

namespace StopNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int m = int.Parse (Console.ReadLine ());
			int stopNum = int.Parse (Console.ReadLine ());

			for (int i = m; i >= n; i--) 
			{
				if ((i % 2 == 0) && (i % 3 == 0)) 
				{
					if (i == stopNum) 
					{
						break;
					} 
					else
					{
						Console.Write (i + " ");
					}
				}
			}
		}
	}
}
