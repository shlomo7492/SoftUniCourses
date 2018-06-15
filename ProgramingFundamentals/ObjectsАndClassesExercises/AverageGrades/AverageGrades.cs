using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<Student> students = GetAllStudents ();
			PrintStudents (students);
		}
		static List<double> GetGrades(string[] inputArr)
		{
			List<double> grades = new List<double> ();
			for (int i = 1; i < inputArr.Length; i++) 
			{
				grades.Add(double.Parse (inputArr [i]));
			}
			return grades;
		}
		static Student GetStudent()
		{
			Student student = new Student ();
			string[] inputArr = Console.ReadLine ().Split (' ');
			student.Name = inputArr [0];
			student.Grades = GetGrades (inputArr);
			student.Average = student.Grades.Average ();
			return student;
		}
		static List<Student> GetAllStudents()
		{
			List<Student> students = new List<Student> ();
			int numberOfStuds = int.Parse (Console.ReadLine ());
			for (int i = 0; i < numberOfStuds; i++) 
			{
				students.Add(GetStudent ());
			}
			return students;
		}

		static void PrintStudents(List<Student> students)
		{
			students = students.OrderBy (h => h.Name).ThenByDescending(h => h.Average).ToList ();

			foreach (Student student in students) 
			{
				string name = student.Name;

				if (student.Average >= 5)
				{
					
					Console.WriteLine ($"{student.Name} -> {student.Average:f2}");
				}
			}
		}
	}
	class Student
	{
		private List<double> grades;

		public double Average 
		{
			get;
			set;
		}

		public string Name 
		{
			set;
			get;
		}
		public List<double> Grades
		{
			get
			{
				return grades;
			}
			set
			{
				grades = value;
			}
		}
		public Student()
		{
			this.grades=new List<double>();
		}
	}
}
