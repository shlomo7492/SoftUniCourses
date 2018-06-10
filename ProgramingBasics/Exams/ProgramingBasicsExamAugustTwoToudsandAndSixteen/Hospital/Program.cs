using System;

namespace Hospital
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int daysChecked = int.Parse (Console.ReadLine ());
			int doctors = 7;
			int patients = 0;
			int patientsLeft = 0;
			int dailyPatients = 0;
			for (int i = 1; i <= daysChecked; i++) 
			{
				if (i % 3 == 0) 
				{
					if (patientsLeft > patients) {
						doctors++;
					} 
				}
				dailyPatients = int.Parse (Console.ReadLine ());
				if (dailyPatients > doctors) 
				{
					patientsLeft += (dailyPatients - doctors);
					patients += doctors;
				} 
				else 
				{
					patients += dailyPatients;
				}
			}
			Console.WriteLine("Treated patients: {0}.",patients);
			Console.WriteLine ("Untreated patients: {0}.", patientsLeft);
		}
	}
}
