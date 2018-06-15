using System;
using System.Collections;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        public class ReverseComparer : IComparer
        {
            public int Compare(Object x, Object y)
            {
                if (((int)x % 2 == 0) && ( (int)y % 2 != 0))
                {
                    return -1;
                }
                else if (((int)x % 2 != 0) && ((int)y % 2 == 0))
                {
                    return 1;
                }
                else
                {
                    return   (new CaseInsensitiveComparer()).Compare(y, x);
                }
            }
        }

        static void Main(string[] args)
        {
            IComparer compare = new ReverseComparer();
            int[] compArr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Array.Sort(compArr, compare);
            int index = 0;
            for(int i = 0; i < compArr.Length; i++)
            {
                if(compArr[i]%2!=0)
                {
                    index = i-1;
                    break;
                }
            }
            Console.WriteLine(String.Join(" ", compArr.Take(index + 1).ToArray().OrderBy(x => x).ToArray()) + "// " + String.Join(" ", compArr.Skip(index + 1).ToArray().OrderBy(x=>x).ToArray()));
        }
    }
}
