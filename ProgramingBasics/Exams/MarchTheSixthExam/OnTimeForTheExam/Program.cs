using System;

namespace OnTimeForTheExam
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int examStartH = int.Parse (Console.ReadLine ());
			int examStartM = int.Parse (Console.ReadLine ());
			int arrivalH = int.Parse (Console.ReadLine ());
			int arrivalM = int.Parse (Console.ReadLine ());
			int examTime = examStartH * 60 + examStartM;
			int arrivalTime = arrivalH * 60 + arrivalM;
		
			if ((examTime-arrivalTime) < 0) 
			{
				Console.WriteLine ("Late");
				if (Math.Abs (examTime - arrivalTime) < 60) 
				{
					Console.WriteLine ("{0:##} minutes after the start", Math.Abs (examTime - arrivalTime));
				}
				else 
				{
					Console.WriteLine ("{0:##}:{1:00} hours after the start", Math.Abs (examTime - arrivalTime)/60,Math.Abs (examTime - arrivalTime)%60);
				}
			} 
			else if ((examTime-arrivalTime)<=30) 
			{
				Console.WriteLine ("On time");
				if (Math.Abs (examTime - arrivalTime) > 0) 
				{
					Console.WriteLine("{0:##} minutes before the start", Math.Abs (examTime - arrivalTime));
				}
			}
			else if ((examTime-arrivalTime)>30)
			{
				Console.WriteLine ("Early");
				if (Math.Abs (examTime - arrivalTime) < 60) 
				{
					Console.WriteLine ("{0:##} minutes before the start", Math.Abs (examTime - arrivalTime));
				}
				else 
				{
					Console.WriteLine ("{0:##}:{1:00} hours before the start", Math.Abs (examTime - arrivalTime)/60,Math.Abs (examTime - arrivalTime)%60);
				}
			}
		}
	}
}
