using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> numbers = Console.ReadLine ()
										.Split (' ')
										.Select (x => int.Parse (x))
										.ToList ();
			int length = numbers.Count / 4;
			List<int> leftFold = numbers.Take (length)
										.Reverse()
										.ToList ();
			List<int> rightFold = numbers.Skip ((length) * 3)
										.Take (length)
										.Reverse ()
										.ToList ();
			List<int> upper = leftFold.Concat (rightFold).ToList ();
			List<int> bottom = numbers.Skip (length).Take (length * 2).ToList ();
			numbers = upper.Select ((x, index) => x + bottom [index]).ToList();
			Console.WriteLine (string.Join(" ", numbers));
		}
	}
}
