using System;

namespace DrunkAni
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			uint n = uint.Parse (Console.ReadLine ());
			uint currentStep = 0;
			uint startingStep = 0;
			ulong stepsCount = 0;
			string inputLine = Console.ReadLine ();
			while (inputLine != "Found a free one!")
			{
				
				uint steps = uint.Parse (inputLine);
				currentStep = (startingStep + steps) % n;
				if (currentStep < startingStep)
				{
						Console.WriteLine ("Go {0} steps to the left, Ani.",startingStep-currentStep);
						stepsCount = stepsCount + (startingStep-currentStep);
						startingStep = currentStep;
				}
				else if (currentStep > startingStep)
				{
					Console.WriteLine ("Go {0} steps to the right, Ani.",currentStep-startingStep);
					stepsCount = stepsCount + (currentStep - startingStep);
					startingStep = currentStep;
				} 
				else 
				{	
					Console.WriteLine ("Stay there, Ani.");
				} 
				inputLine = Console.ReadLine ();
			}
			Console.WriteLine ("Moved a total of {0} steps.",stepsCount);
		}
	}
}
