using System;

namespace DifferentIntegersSize
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numStr = Console.ReadLine ();
			long num;
			bool parseTest = long.TryParse (numStr, out num);

			if (parseTest == false) 
			{
				Console.WriteLine ("{0} can't fit in any type", numStr);
			} 
			else 
			{
				Console.WriteLine ("{0} can fit in:", numStr);
				try
				{
					sbyte s = sbyte.Parse(numStr);
					Console.WriteLine("* sbyte");
				}
				catch (Exception)
				{
				}
				try
				{
					byte s = byte.Parse(numStr);
					Console.WriteLine("* byte");
				}
				catch (Exception)
				{
				}
				try
				{
					short s = short.Parse(numStr);
					Console.WriteLine("* short");
				}
				catch (Exception)
				{
				}
				try
				{
					ushort s = ushort.Parse(numStr);
					Console.WriteLine("* ushort");
				}
				catch (Exception)
				{
				}
				try
				{
					int s = int.Parse(numStr);
					Console.WriteLine("* int");
				}
				catch (Exception)
				{
				}
				try
				{
					uint s = uint.Parse(numStr);
					Console.WriteLine("* uint");
				}
				catch (Exception)
				{
				}
				try
				{
					long s = long.Parse(numStr);
					Console.WriteLine("* long");
				}
				catch (Exception)
				{
					
				}
			}

		}
	}
}
