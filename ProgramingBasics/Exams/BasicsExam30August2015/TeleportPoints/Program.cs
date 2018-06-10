using System;

namespace TeleportPoints
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double[] xArr = new double[4];
			double[] yArr = new double[4];
			for (int i = 0; i < 4; i++) 
			{
				string[] inputArr = Console.ReadLine ().Split(' ');
				xArr [i] = double.Parse(inputArr [0]);
				yArr [i] = double.Parse(inputArr [1]);
			}
			double radius = double.Parse (Console.ReadLine ());
			double stepH = double.Parse (Console.ReadLine ());
			int counter = 0;
			for (double jumpX = 0; jumpX <= radius; jumpX += stepH) 
			{
				//right top
				for (double jumpY = 0; jumpY <= radius; jumpY += stepH) 
				{
					if ((Math.Pow (jumpX - 0, 2) + Math.Pow (jumpY - 0, 2)) <= Math.Pow (radius, 2))
					{
						if (((jumpX < xArr [1]) && (jumpX > xArr[0])) && ((jumpY > yArr [1]) && (jumpY < yArr[2])))
						{
							counter++;
						}
					}
				}
				//right bottom
				for (double jumpY = -stepH; jumpY >= -radius; jumpY -= stepH) 
				{
					if ((Math.Pow (jumpX - 0, 2) + Math.Pow (jumpY - 0, 2)) <= Math.Pow (radius, 2))
					{
						if (((jumpX < xArr [1]) && (jumpX > xArr[0])) && ((jumpY > yArr [1]) && (jumpY < yArr[2])))
						{
							counter++;
						}
					}
				}
			}
			for (double jumpX = -stepH; jumpX >= -radius; jumpX -= stepH) 
			{
				//left top
				for (double jumpY = 0; jumpY <= radius; jumpY += stepH) 
				{
					if ((Math.Pow (jumpX-0, 2) + Math.Pow (jumpY-0, 2)) <= Math.Pow (radius, 2))
					{
						if (((jumpX < xArr [1]) && (jumpX > xArr[0])) && ((jumpY > yArr [1]) && (jumpY < yArr[2])))
						{
							counter++;
						}
					}
				}
				//left bottom
				for (double jumpY = -stepH; jumpY >= -radius; jumpY -= stepH) 
				{
					if ((Math.Pow (jumpX-0, 2) + Math.Pow (jumpY-0, 2)) <= Math.Pow (radius, 2))
					{
						if (((jumpX < xArr [1]) && (jumpX > xArr[0])) && ((jumpY > yArr [1]) && (jumpY < yArr[2])))
						{
							counter++;
						}
					}
				}
			}
			Console.WriteLine (counter);
		}
	}
}
