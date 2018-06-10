using System;

namespace WaveBits
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ulong inputNum = ulong.Parse (Console.ReadLine ());
			byte[] byteArr = new byte[64];
			for (int i = 0; i <= 63; i++) 
			{
				ulong changer = 1ul;
				changer = changer << i;
				if ((inputNum & changer) == 0)
				{
					byteArr [i] = 0;
				} 
				else 
				{
					byteArr [i] = 1;
				}
			}
			string waves="";
			int currentBit = 0;
			while (currentBit <= 63)
			{
				bool exitRule = false;
				int lenght =  0;
				int startingBit = currentBit;
				while (exitRule == false) 
				{
					if ((byteArr [currentBit] == 0) && (currentBit == 0)) 
					{
						exitRule = true;
						currentBit++;
					} 
					else if ((currentBit == 0) && (byteArr [currentBit] == 1)) 
					{
						if ((byteArr [currentBit + 1] == 0) && (byteArr [currentBit + 2] == 1)) 
						{
							lenght++;
							currentBit++;
						} 
						else 
						{
							exitRule = true;
							currentBit++;
						}
					} 
					else if ((currentBit == 63) && (byteArr [currentBit] == 0)) 
					{
						exitRule = true;
						currentBit++;
					} 
					else if ((currentBit == 63) && (byteArr [currentBit] == 1)) 
					{
						if ((byteArr [currentBit - 1] == 0) && (byteArr [currentBit - 2] == 1)) 
						{
							exitRule = true;
							lenght++;
							currentBit++;
						} 
						else 
						{
							exitRule = true;
							currentBit++;
						}
					} 
					else if ((byteArr [currentBit] == 0) && (byteArr [currentBit + 1] == 0)) 
					{
						exitRule = true;
						currentBit++;
					} 
					else if ((byteArr [currentBit] == 0) && (byteArr [currentBit - 1] == 0)) 
					{
						exitRule = true;
						currentBit++;
					} 
					else if ((byteArr [currentBit] == 0) && (byteArr [currentBit + 1] == 1) && (byteArr [currentBit - 1] == 1)) 
					{
						lenght++;
						currentBit++;
					} 
					else if (byteArr [currentBit] == 1)
					{
						if ((byteArr [currentBit] == 1) && (byteArr [currentBit - 1] == 0) && (byteArr [currentBit - 2] == 1))
						{
							lenght++;
							currentBit++;
						}
						else if ((byteArr [currentBit] == 1) && (byteArr [currentBit + 1] == 0) && (byteArr [currentBit + 2] == 1)) 
						{
							lenght++;
							currentBit++;
						} 
						else
						{
							exitRule = true;
							currentBit++;
						}
					}
					else 
					{
						exitRule = true;
						currentBit++;
					}  


						//((byteArr [currentBit] == 1) && (byteArr [currentBit - 1] == 0) && (byteArr [currentBit - 2] == 1))
				}
				if (lenght > 2) 
				{
					waves = waves + ";" + startingBit + " " + lenght;
				}
			}
			if (waves.Length >0)
			{
				int waveLenght = 0;
				int start = 0;
				string[] separator = { ";" };
				string[] wavesArr = waves.Split(separator,StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i <= wavesArr.Length - 1; i++) {
				}
				//Chosing the longest wave in the right
				for (int i = 0; i<= wavesArr.Length - 1; i++) 
				{
					string[] splited = (wavesArr [i]).Split (' ');
					int lenghTmp = int.Parse (splited [1]);
					if (lenghTmp > waveLenght) 
					{
						start = int.Parse (splited [0]);
						waveLenght = lenghTmp;
					}
				}
				//moving and replasing bits
				for (int i = start; i <= 63-waveLenght; i++) 
				{
					byteArr [i] = byteArr [i + waveLenght];
				}
				//filling with zeros to the left
				for (int i = 0; i <= waveLenght - 1; i++) 
				{
					byteArr [63 - i] = 0;
				}
				ulong num=0ul;
				for (int i = 0; i <= 63; i++) 
				{
					ulong changer = 1ul;
					changer = changer << i;
					if (byteArr[i] == 0)
					{
						continue;
					} 
					else 
					{
						num = num ^ changer;
					}				
				}
				Console.WriteLine (num);
			}
			else
			{
				Console.WriteLine ("No waves found!");
			}
		}
	}
}
