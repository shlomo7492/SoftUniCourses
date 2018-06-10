using System;

namespace TrainingLab
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float w = float.Parse (Console.ReadLine ());
			float h = float.Parse (Console.ReadLine ());

			w = w * 100;
			h = (h * 100) - 100;

			int rows = (int)(w / 120);
			int cols = (int)(h / 70);
			int places = rows * cols - 3;

			Console.WriteLine (places);
 		}
	}
}
