using System;

namespace EmployeeData
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string name = "Amanda";
			string surname = "Jonson";
			byte age = 27;
			char sex = 'f';
			long id = 8306112507;
			int emploeeNum = 27563571;
			Console.WriteLine ("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}\n", name, surname, age, sex, id, emploeeNum);
		}
	}
}
