using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace BookLibrary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Library myLibrary = GetBooksLibrary ();
			PrintLibrary (myLibrary);
		}
		//Sets one book data and parameters
		static Book GetBook (string[] bookData)
		{
			Book book = new Book ();
			book.Title = bookData [0];
			book.Author = bookData [1];
			book.Publisher = bookData [2];
			book.ReleaseDate=DateTime.ParseExact(bookData[3],"dd.MM.yyyy",CultureInfo.InvariantCulture);
			book.ISBN = bookData [4];
			book.Price = decimal.Parse (bookData [5]);
			return book;
		}
		//Creates Library instance and add all specified Books, calls on GetBook()
		static Library GetBooksLibrary()
		{
			int bookEntries = int.Parse (Console.ReadLine ());
			List<Book> bookList = new List<Book> ();
			Library bookLibrary = new Library ();
			for (int i = 1; i <= bookEntries; i++) 
			{
				string[] bookData = Console.ReadLine ().Split (' ');
				bookList.Add (GetBook (bookData));				
			}
			bookLibrary.Books = bookList;
			bookLibrary.Name="Library";
			return bookLibrary;
		}
		//Creates and returns Dictionary and assign the Key=Autor, Value = Sum of prices
		static Dictionary<string,decimal> GetBookPrices(Library myLibrary)
		{
			List<string> libraryAuthors = myLibrary.Books.Select (s => s.Author).Distinct ().ToList ();
			Dictionary<string,decimal> myLibSortedResult = new Dictionary<string,decimal> ();
			for (int i = 0; i < libraryAuthors.Count; i++) 
			{
				myLibSortedResult.Add (libraryAuthors [i], myLibrary.Books
														.Where (x => x.Author == libraryAuthors [i])
														.Select (x => x.Price)
														.Sum ());
			}
			return myLibSortedResult;
		}

		//Prints each element of the Dictionary created by calling GetBookPrices Author -> PriceSum
		static void PrintLibrary(Library myLibrary)
		{
			//Dictionary<string,decimal> myLibSorted = GetBookPrices (myLibrary).OrderByDescending(x=>x.Value).ToDictionary (x => x,x=>x.Value);
			var myLibSorted = GetBookPrices (myLibrary).OrderByDescending(x=>x.Value);

			foreach (var element in myLibSorted) 
			{
				Console.WriteLine ($"{element.Key} -> {element.Value:f2}");
			}
		}
	}
	class Book
	{
		public string Title
		{ 
			get; 
			set;
		}
		public string Author
		{ 
			get; 
			set;
		}
		public string Publisher
		{ 
			get; 
			set;
		}
		public DateTime ReleaseDate
		{ 
			get; 
			set;
		}
		public string ISBN
		{ 
			get; 
			set;
		}
		public decimal Price
		{ 
			get; 
			set;
		}
	}
	class Library
	{
		public string Name
		{ 
			get; 
			set;
		}
		public List<Book> Books
		{ 
			get; 
			set;
		}
	}
}
