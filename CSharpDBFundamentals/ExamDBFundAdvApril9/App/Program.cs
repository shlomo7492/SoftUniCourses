using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels;
using Data;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var telescope = new Telescope()
            {
                Name = "Golyamata Lupa",
                Location = "Vitosha",
                MirrorDiameter = -1
            };
            Console.WriteLine($"{telescope.Name}");
            if(telescope.MirrorDiameter==null)
            {
                Console.WriteLine("NULL");
            }
            var context = new ExamContext();
            context.Telescopes.Add(telescope);
            context.SaveChanges();
        }
    }
}
