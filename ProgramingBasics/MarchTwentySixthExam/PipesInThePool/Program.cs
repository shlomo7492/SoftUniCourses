using System;

namespace PipesInThePool
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int v = int.Parse (Console.ReadLine ());
			int pipeOne = int.Parse (Console.ReadLine ());
			int pipeTwo = int.Parse (Console.ReadLine ());
			float timeOut = float.Parse (Console.ReadLine ());

			if ((pipeOne + pipeTwo) * timeOut > v)
			{
				Console.WriteLine ("For {0} hours the pool overflows with {1} liters.",timeOut,(((pipeOne + pipeTwo) * timeOut) - v));
			} 
			else 
			{
				Console.WriteLine ("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",(int)((((pipeOne + pipeTwo) * timeOut)/v)*100),(int)(((pipeOne*timeOut)/((pipeOne + pipeTwo) * timeOut))*100), (int)(((pipeTwo*timeOut)/((pipeOne + pipeTwo) * timeOut))*100));
			}
		}
	}
}
