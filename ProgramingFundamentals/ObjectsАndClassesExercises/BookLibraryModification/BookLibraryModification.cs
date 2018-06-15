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
			book.Price = double.Parse (bookData [5]);
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
		static List<Book> GetBooksReleasedAfterGivenDate(Library myLibrary,DateTime givenDate)
		{
			List<Book> bookList = new List<Book> ();
			for (int i = 0; i < myLibrary.Books.Count; i++) 
			{
				if (myLibrary.Books[i].ReleaseDate > givenDate)
				{	
					bookList.Add (myLibrary.Books[i]);
				}
			}
			return bookList;
		}
		//Prints each element of the Dictionary created by calling GetBookPrices Author -> PriceSum
		static void PrintLibrary(Library myLibrary)
		{
			DateTime givenDate =DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy",CultureInfo.InvariantCulture);
			List<Book> bookList = GetBooksReleasedAfterGivenDate (myLibrary, givenDate);
			List<Book> sortedBookList = bookList.OrderBy (x => x.ReleaseDate).ThenBy (x => x.Title).ToList ();
			foreach (Book book in sortedBookList) 
			{
				Console.WriteLine ("{0} -> {1}", book.Title, book.ReleaseDate.ToString ("dd.MM.yyyy"));
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
		public double Price
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
