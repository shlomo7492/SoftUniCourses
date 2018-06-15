using System;

namespace CubeProperties
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double cubeSide = double.Parse (Console.ReadLine ());
			string action = Console.ReadLine ();
			GetAction (cubeSide, action);
		}
		static double GetCubeVolume (double cubeSide)
		{
			return Math.Pow (cubeSide, 3);
		}
		static double GetCubeSurfaceArea (double cubeSide)
		{
			return Math.Pow (cubeSide, 2) * 6;
		}
		static double GetCubeFaceDiagonalLenght (double cubeSide)
		{
			return Math.Sqrt (2)* cubeSide;
		}
		static double GetCubeSpaceDiagonalLenght (double cubeSide)
		{
			return Math.Sqrt (3)*cubeSide;
		}
		static void GetAction (double cubeSide, string action)
		{
			switch (action) 
			{
			case "face":
				Console.WriteLine ("{0:f2}",GetCubeFaceDiagonalLenght (cubeSide));
				break;
			case "space":
				Console.WriteLine ("{0:f2}",GetCubeSpaceDiagonalLenght (cubeSide));
				break;
			case "area":
				Console.WriteLine ("{0:f2}",GetCubeSurfaceArea (cubeSide));
				break;
			case "volume":
				Console.WriteLine ("{0:f2}",GetCubeVolume (cubeSide));
				break;
			default:
				break;
			}
		}
	}
}
