using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Stores
{
    public class StationStore
    {
        public static void AddStation(ICollection<Station> stations)
        {
            using (var ctx = new StationsContext())
            {
                foreach (var station in stations)
                {
                    if (((station.Name.Length > 50) || (station.Town.Length > 50)) || (station.Name == null))
                    {
                        Console.WriteLine("Invalid data format.");
                    }
                    else if (station.Town == null)
                    {
                        station.Town = station.Name;
                        ctx.Stations.Add(station);
                        Console.WriteLine($"Record {station} successfully imported.");
                    }
                }
                ctx.SaveChanges();
            }
        }
    }
}
