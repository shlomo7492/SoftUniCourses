using System;
using System.Collections.Generic;
using System.Linq;

namespace RoliTheCoder
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string inputLine = Console.ReadLine ();
			List<Events> events = new List<Events> ();
			while (inputLine != "Time for Code") 
			{
				string[] eventsStr = inputLine.Split (new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
				Events currentEvent = new Events ();
				currentEvent = GetEvent (eventsStr);
				int id = currentEvent.ID;
				string name = currentEvent.Name;
				bool isID = false;
				bool isName = false;
				for (int i = 0; i < events.Count; i++) 
				{
					
					if ((id == events [i].ID)&&(name==events[i].Name))
					{
						isID = true;
						isName = true;
						break;
					}

						
				}
				if (!isID && !isName) 
				{
					events.Add (currentEvent);
				} 
				else 
				{
				}

				inputLine = Console.ReadLine ();
			}
			events = events.OrderByDescending (x => x.Participant.Count).ThenBy(x=>x.Name).ToList ();

			PrintResult (events);
			
		}
		static string GetNameRemovingLeadinChar(string name)
		{
			string newname = "";
			for (int i = 1; i < name.Length; i++) 
			{
				newname += name [i];
			}
			return newname;
		}
		static Events GetEvent(string[] input)
		{			
			Events myEvent = new Events ();
			
			myEvent.ID = int.Parse (input [0]);
			myEvent.Name = GetNameRemovingLeadinChar (input [1]);
			for (int i = 2; i < input.Length; i++) 
			{
				myEvent.Participant.Add (input [i]);
			}
			return myEvent;
		}
		static void PrintResult(List<Events> events)
		{
			foreach (Events thisEvent in events) 
			{
				Console.WriteLine($"{thisEvent.Name} - {thisEvent.Participant.Count}");
				Console.WriteLine (string.Join ("\n", thisEvent.Participant.OrderBy (x => x).ToList ()));
			}
		}
	}
	class Events
	{
		private List<string> participant=new List<string>();
		public int ID
		{ 
			get;
			set;
		}
		public string Name
		{
			get;
			set;
		}
		public List<string> Participant	
		{
			get
			{ 
				return participant;
			}
			set
			{ 
				participant = value;
			}
		}


	}
}
