using System;
using System.Linq;

namespace RectanglePosition
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Rectangle rect1 = ReadRectangle ();
			Rectangle rect2 = ReadRectangle ();
			bool inside = rect1.IsInside (rect2);
			Console.WriteLine (inside ? "Inside" : "Not inside");
		}
		static Rectangle ReadRectangle()
		{
			int[] rectInput = Console.ReadLine ()
				.Split (' ')
				.Select (int.Parse)
				.ToArray ();
			Rectangle rect = new Rectangle ();
			rect.Top = rectInput [0];
			rect.Left = rectInput [1];
			rect.Width = rectInput [2];
			rect.Height = rectInput [3];
			return rect;
		}
	}
	class Rectangle
	{
		//specify the Y value of the top-left corner
		public int Top 
		{
			get;
			set;
		}

		//specify the X value of the top-left corner
		public int Left
		{
			get;
			set;
		}
		public int Width 
		{
			get;
			set;
		}
		public int Height
		{
			get;
			set;
		}

		public int CalcArea()
		{
			return Width * Height;
		}
		public int Bottom
		{
			get
			{
				return Top + Height;
			}
		}
		public int Right
		{
			get
			{
				return Left + Width;
			}
		}
		public bool IsInside(Rectangle r)
		{
			return (r.Left<=Left)&&(r.Right>=Right)&&(r.Top<=Top)&&(r.Bottom>=Bottom);
		}
	}
}
