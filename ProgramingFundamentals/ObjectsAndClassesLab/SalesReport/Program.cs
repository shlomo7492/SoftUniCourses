using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			List<Sale> sales = GetSales ();
			string[] towns = sales
								.Select (x => x.Town)
								.Distinct ()
								.OrderBy(x => x)
								.ToArray();
			foreach (var town in towns) 
			{
				decimal salesByTown = sales
										.Where (x => x.Town == town)
										.Select (x => x.Price * x.Quantity)
										.Sum ();
				Console.WriteLine ($"{town} -> {salesByTown:f2}");
			}
		}
		static List<Sale> GetSales()
		{
			int numberOfSales = int.Parse (Console.ReadLine ());
			List<Sale> sales = new List<Sale> ();
			for (int i = 0; i < numberOfSales; i++) 
			{
				sales.Add (GetSingleSale ());
			}
			return sales;
		}
		static Sale GetSingleSale()
		{
			string[] oneSale = Console.ReadLine ().Split (' ');
			Sale singleSale = new Sale ();
			singleSale.Town = oneSale [0];
			singleSale.Product = oneSale [1];
			singleSale.Price = decimal.Parse(oneSale [2]);
			singleSale.Quantity = decimal.Parse(oneSale [3]);
			return singleSale;
		}
	}
	class Sale
	{
		public string Town 
		{
			get;
			set;
			
		}
		public string Product 
		{
			get;
			set;
		}
		public decimal Price 
		{
			get;
			set;
		}
		public decimal Quantity 
		{
			get;
			set;
		}
	}
}
