using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Stores
{
    public class SeatingClassStore
    {
        public static void AddSeatingClass(ICollection<SeatingClass> seatclasses)
        {
            using (var ctx = new StationsContext())
            {
                foreach (var seatclass in seatclasses)
                {
                    if ((seatclass.Name.Length > 30)
                        || (seatclass.Abbreviation.Length < 2) 
                        || (seatclass.Abbreviation.Length > 2)
                        ||(ctx.SeatingClasses.Where(sc => sc.Name == seatclass.Name)!=null))
                    {
                        Console.WriteLine("Invalid data format.");
                    }
                    else
                    {
                        ctx.SeatingClasses.Add(seatclass);
                    }
                }
                ctx.SaveChanges();
            }
        }
    }
}
