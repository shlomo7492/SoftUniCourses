	using System;

	namespace BonusScore
	{
		class MainClass
		{
			public static void Main (string[] args)
			{
				Console.WriteLine ("Enter score: ");
				var score = double.Parse (Console.ReadLine ());
				var bonus = 0.0;
				if (score <= 100) 
				{
					bonus = 5.0;
				}
				if((score > 100)&&(score < 1000))
				{
					bonus = score / 5.0;
				}
				if (score > 1000)
				{
					bonus = score / 10.0;
				}
				if ((score % 2) == 0) 
				{
					bonus += 1.0;
				} 
				if (((score % 5) == 0)&&((score%10) != 0))
				{
					bonus += 2.0;
				}
				Console.WriteLine ("Bonus score: {0:####.##}", bonus);
				Console.WriteLine ("Total score: {0:####.##}", score+bonus);

			}
		}
	}
