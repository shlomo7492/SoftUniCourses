using System;

namespace DailyCalorieIntake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			decimal weight = decimal.Parse (Console.ReadLine ());
			decimal height = decimal.Parse (Console.ReadLine ());
			decimal age = decimal.Parse (Console.ReadLine ());
			char gender = char.Parse (Console.ReadLine ());
			int workouts = int.Parse(Console.ReadLine());
			decimal dci = 0m;
			decimal bmr = 0m;
			if (gender == 'm') 
			{
				bmr = (66.5m + (13.75m * (weight / 2.2m)) + (5.003m * (height * 2.54m)) - (6.755m * age));
			}
			else 
			{
				bmr = 655m + (9.563m * (weight / 2.2m)) + (1.850m * (height * 2.54m)) - (4.676m * age);
			}
			if ((workouts >= 1) && (workouts <= 3)) 
			{
				dci = bmr * 1.375m;
			} 
			else if (workouts <= 0) 
			{
				dci = bmr * 1.2m;
			} 
			else if (workouts <= 6) 
			{
				dci = bmr * 1.55m;
			} 
			else if (workouts <= 9) 
			{
				dci = bmr * 1.725m;
			} 
			else 
			{
				dci = bmr * 1.9m;
			} 
			Console.WriteLine ((long)dci);
		}
	}
}
