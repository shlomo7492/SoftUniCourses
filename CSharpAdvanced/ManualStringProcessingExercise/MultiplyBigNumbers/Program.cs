using System;
using System.Linq;

namespace MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int[] bigNumArr = new int[bigNum.Length + 1];
            int n = int.Parse(Console.ReadLine());

            for(int i=1;i<bigNumArr.Length;i++)
            {
                bigNumArr[i] = int.Parse(bigNum[i - 1] + "");
            }
            for (int i = 1; i < bigNumArr.Length; i++)
            {
                bigNumArr[i] *= n;//8*4=32
            }
            for(int i=bigNumArr.Length-1;i>0;i--)
            {
                int reminder = (int)Math.Floor((decimal)(bigNumArr[i]) /10);//3
                bigNumArr[i] = bigNumArr[i] - reminder * 10;//32-3*10=2
                bigNumArr[i - 1] += reminder;
            }
            Console.WriteLine(string.Join("", bigNumArr[0] == 0 ? bigNumArr.Skip(1) : bigNumArr));
        }
    }
}
