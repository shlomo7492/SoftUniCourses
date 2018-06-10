using System;

namespace PerfectGirlFriend
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string endLine = "";
			int perfectDateCount = 0;
			while (endLine != "Enough dates!") 
			{
				string line = Console.ReadLine ();
				if (line == "Enough dates!") 
				{
					break;
				}
				string[] girl=line.Split('\\');
				int date = 0;
				switch (girl [0]) 
				{
					case "Monday":
						date = 1;
						break;
					case "Tuesday":
						date = 2;
						break;
					case "Wednesday":
						date = 3;
						break;
					case "Thursday":
						date = 4;
						break;
					case "Friday":
						date = 5;
						break;
					case "Saturday":
						date = 6;
						break;
					case "Sunday":
						date = 7;
						break;
					default:
						break;
				}
				int phone = 0;
				for (int i = 1; i <= 10; i++) {
					phone = phone + int.Parse(girl [1] [i - 1]+"");
				}
				string braNum="";
				for (int i = 0; i <= girl [2].Length-2; i++) 
				{
					braNum = braNum + girl [2] [i];
				}
				int bra = int.Parse(braNum)	 * girl [2] [girl[2].Length-1];
				int name = girl[3][0]*girl[3].Length;
				int result = date + phone + bra - name;
				if (result > 6000)
				{
					Console.WriteLine ("{0} is perfect for you.", girl [3]);
					perfectDateCount++;
				} 
				else 
				{
					Console.WriteLine ("Keep searching, {0} is not for you.", girl [3]);
				}
			}
			Console.WriteLine (perfectDateCount);
		}
	}
}
