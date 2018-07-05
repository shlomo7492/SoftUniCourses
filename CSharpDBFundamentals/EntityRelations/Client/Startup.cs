using Data;
using Models;
using System;

namespace StudentSystem
{
    class Startup
    {
        static void Main(string[] args)
        {
            StudentsContext ctx = new StudentsContext();
            Student pesho = new Student()
            {
                Name = "Pesho",
                RegisteredOn = new DateTime(2016, 06, 02)
            };
            Student tosho = new Student()
            {
                Name = "Todor",
                PhoneNumber="+359899123932",
                BirthDate=new DateTime(1987,01,23),
                RegisteredOn = new DateTime(2016, 05, 15)
            };
            Student stami = new Student()
            {
                Name = "Stamat",
                PhoneNumber = "+35985522341",
                RegisteredOn = new DateTime(2016, 05, 31)
            };
            Course programingBasics = new Course()
            {
                Name = "Programing Basics June-August 2016",
                Description = "Entry module with one course",
                StartDate = new DateTime(2016, 06, 18),
                EndDate = new DateTime(2016, 08, 28)
            };
            Resource videoLessonOne = new Resource("video")
            {
                Name="Simple calculation.",
                Url = "https://softuni.bg/trainings/resources/video/9174/video-screen-18-06-2016-georgi-inkov-programming-basics-june-2016"
            };
            pesho.Courses.Add(programingBasics);
            tosho.Courses.Add(programingBasics);
            stami.Courses.Add(programingBasics);
            programingBasics.Resourses.Add(videoLessonOne);

            ctx.SaveChanges();
        }
    }
}
