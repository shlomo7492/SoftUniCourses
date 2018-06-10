using System;

namespace ShuffleBits
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			uint firstNum = uint.Parse (Console.ReadLine ());
			uint secondNum = uint.Parse (Console.ReadLine ());
			ulong resultNum = 0ul;

			if (firstNum >= secondNum) 
			{
				for (int i = 0; i < 32; i++) 
				{
					uint changer = 1u;
					ulong changerResult = 2ul;
					changer = changer << i;
					if ((firstNum & changer) != 0) 
					{
						changerResult = changerResult << (i*2);
						resultNum = resultNum ^ changerResult;
					}
				}
				for (int i = 0; i < 32; i++) 
				{
					uint changer = 1u;
					ulong changerResult = 1ul;
					changer = changer << i;
					if ((secondNum & changer) != 0) 
					{
						changerResult = changerResult << (i*2);
						resultNum = resultNum ^ changerResult;
					}
				}

			}
			else
			{
				for (int i = 0; i <= 15; i++) 
				{
					uint changer = 1u;
					changer = changer << (i * 2);
					if ((firstNum & changer) != 0) 
					{
						resultNum = resultNum + (ulong)Math.Pow(2,((i*4)+2));
					} 
					changer = changer << 1;
					if ((firstNum & changer) != 0) 
					{
						resultNum = resultNum + (ulong)Math.Pow(2,((i*4)+3));
					} 

				}
				for (int i = 0; i <= 15; i++) 
				{
					uint changer = 1u;
					changer = changer << (i * 2);
					if ((secondNum & changer) != 0) 
					{
						resultNum = resultNum + (ulong)Math.Pow(2,(i*4));
					} 
					changer = changer << 1;
					if ((secondNum & changer) != 0) 
					{
						resultNum = resultNum + (ulong)Math.Pow(2,((i*4)+1));

					} 

				}
			}
			Console.WriteLine (resultNum);
		}
	}
}
