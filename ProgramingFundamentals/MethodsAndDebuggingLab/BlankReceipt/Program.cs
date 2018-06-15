using System;

namespace BlankReceipt
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PrintReceipt ();
		}
		public static void PrintHeader ()
		{
			Console.WriteLine ("CASH RECEIPT");
			Console.WriteLine ("------------------------------");
		}
		public static void PrintFooter()
		{
			Console.WriteLine ("------------------------------");
			Console.WriteLine ("\u00A9 SoftUni");
		}
		public static void PrintBody ()
		{
			Console.WriteLine ("Charged to____________________");
			Console.WriteLine ("Received by___________________");
		}
		public static void PrintReceipt ()
		{
			PrintHeader ();
			PrintBody ();
			PrintFooter ();
		}
	}
}
