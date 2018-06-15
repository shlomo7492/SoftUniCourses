using System;

namespace PracticeIntegerNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			sbyte sbyteNum = -100;
			byte byteNum = 128;
			short shortNum = -3540;
			ushort ushortNum = 64876;
			uint uintNum = 2147483648;
			int intNum = -1141583228;
			long longNum = -1223372036854775808;
			Console.Write ("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n", sbyteNum, byteNum, shortNum, ushortNum, uintNum, intNum, longNum);
		}
	}
}
