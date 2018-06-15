using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*	Dictionary<string,decimal> sales = GetPrice();
			List < Customer > customers= GetCustomerList ();
			PrintBill (customers, sales);*/
			List < Customer > customers= GetCustomerList ();
			foreach (var customer in customers) 
			{
				Console.WriteLine (customer.Name + ":: " 
					+ customer.ShopingList.Select (x => x.Key) + " -> " 
					+ customer.ShopingList.Select (x => x.Value));
			}
		}

		static void PrintBill(List < Customer > customers,Dictionary<string,decimal> sales)
		{
			foreach (var sale in sales) 
			{
				foreach (Customer customer in customers) 
				{
					foreach (var purchase in customer.ShopingList) 
					{
						if (sale.Key == purchase.Key) 
						{
							customer.Bill += purchase.Value * sale.Value;
						}
					}
					Console.WriteLine ("CustomerBill = " + customer.Bill);
				}
			}

			decimal totalBill = 0.0m;

			foreach (Customer customer in customers) 
			{
				Console.WriteLine (customer.Name);
				foreach (var purchase in customer.ShopingList) 
				{
					if (sales.ContainsKey(purchase.Key)) 
					{
						Console.WriteLine ("--{0} - {1}",purchase.Key,purchase.Value);
					}
				}
				Console.WriteLine ("Bill: {0:f2}", customer.Bill);
				totalBill += customer.Bill;
			}

			Console.WriteLine ("Total bill: {0}", totalBill);
		}

		static Dictionary<string,decimal> GetPrice()
		{
			int numberOfPrices = int.Parse (Console.ReadLine ());
			Dictionary<string,decimal> sales = new Dictionary<string, decimal> ();
			for (int i = 1; i <= numberOfPrices; i++) 
			{
				string[] sale = Console.ReadLine ().Split ('-');
				sales [sale [0]] = decimal.Parse (sale [1]);

			}
			Console.WriteLine ("End of product and prices input...");
			return sales;
		}

		static Customer GetSingleCustomer (string[] inputArr)
		{
			Customer customer = new Customer ();
			customer.Name = inputArr [0];
			customer.ShopingList.Add (inputArr [1],int.Parse (inputArr [2]));
			if (customer.ShopingList.ContainsKey ("test")) 
			{
				customer.ShopingList.Remove ("test");
			}
			return customer;
		}

		static List<Customer> GetCustomerList()
		{
			string inputLine = Console.ReadLine ();
			char[] separator = new char[]{ '-', ',' };
			List<Customer> customers = new List<Customer> ();
			while (inputLine != "end of clients") 
			{
				string[] inputArr = inputLine.Split (separator, StringSplitOptions.RemoveEmptyEntries);
				Console.WriteLine(inputArr[0]+"-"+inputArr[1]+","+inputArr[2]);
				foreach (var element in customers)
				{
					if (element.Name == inputArr[0]) 
					{
						if (element.ShopingList.ContainsKey(inputArr[1]))
						{
							Console.WriteLi																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																												ne ("TUKA 1");
							element.ShopingList [inputArr[1]] += int.Parse(inputArr[2]);
						}
						else
						{
							element.ShopingList [inputArr [1]] = int.Parse (inputArr [2]);
						}
					}
					else
					{
						customers.Add (GetSingleCustomer(inputArr));
					}
					Console.WriteLine (element.Name + "--" + element.ShopingList [inputArr [1]] + "--" + inputArr [1]);	
				}
				inputLine = Console.ReadLine ();
			}
			return customers;
		}
	}

	class Customer
	{
		Dictionary<string,int> shopingList = new Dictionary<string, int>{["test"]=1};
		public string Name 
		{
			get;
			set;
		}
		public Dictionary<string,int> ShopingList
		{
			get
			{
				return shopingList;
			}
			set
			{
				shopingList = value;
			}
		}
		public decimal Bill
		{
			get;
			set;
		}
	}
}
