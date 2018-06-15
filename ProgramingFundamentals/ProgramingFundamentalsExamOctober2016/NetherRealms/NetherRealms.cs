using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetherRealms
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] separator = new char[]{ ' ', ',' };
			try
			{
				string[] demonNames = Console.ReadLine ().Split (separator, StringSplitOptions.RemoveEmptyEntries);
				SortedDictionary<string,Demon> demonsList =new SortedDictionary<string, Demon>();

				foreach (string demon in demonNames) 
				{
					Demon demonInfo= new Demon ();
					demonInfo.Name = demon;
					demonInfo.Health = GetHealth (demon);
					double damage = GetDamageBase (demon);
					double[] changers = GetSpecials (demon);
					demonInfo.Damage = GetFullDamage (damage, changers);
					demonsList [demon] = demonInfo;
				}
				foreach (KeyValuePair<string,Demon> demonInfo in demonsList) 
				{
					Console.WriteLine ($"{demonInfo.Value.Name} " +
						$"- {demonInfo.Value.Health} health, {demonInfo.Value.Damage:f2} damage");

				}
			}
			catch
			{
			}

		}
		static int GetHealth(string name)
		{
			int healthPoint = 0;
			string health = "";
			string pattern=@"[A-z]|[^\/,^\d,^\.,^\*,^\-,^\+]";
			MatchCollection matches = Regex.Matches (name, pattern);
			foreach (Match match in matches) 
			{
				health += match.Groups[0].Value;
			}
			foreach (char symbol in health) 
			{
				healthPoint += symbol;
			}
			return healthPoint;
		}
		static double[] GetSpecials(string name)
		{
			
			string pattern=@"[\/\*]";
			MatchCollection matches = Regex.Matches (name, pattern);
			double[] multiplyers = new double[matches.Count];
			for (int i = 0; i < multiplyers.Length; i++) 
			{
				if (matches [i].Groups [0].Value == "/") 
				{
					multiplyers [i] = 0.5;
				} 
				else
				{
					multiplyers [i] = 2;
				}
			}
			return multiplyers;
		}
		static double GetDamageBase(string name)
		{
			string pattern = @"[\-\d|\d]\d\.[\d]{0,}|[\d]\.[\d]{0,}|\d|\-\d|\+\d";
			MatchCollection matches = Regex.Matches (name, pattern);
			double damage = 0;
			foreach (Match match in matches) 
			{
				damage += double.Parse (match.Groups [0].Value);
			}
			return damage;
		}
		static double GetFullDamage(double damage, double[] changers)
		{
			for (int i = 0; i < changers.Length; i++) 
			{
				damage *= changers [i];	
			}
			return damage;
		}
	}


	class Demon
	{
		public string Name
		{
			get;
			set;
		}
		public int Health
		{
			get;
			set;
		}
		public double Damage
		{
			get;
			set;
		}
	}
}
