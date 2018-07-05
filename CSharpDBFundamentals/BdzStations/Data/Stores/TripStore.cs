using Data.DTOS.Imports;
using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Stores
{
    public class TripStore
    {
        public static void AddTrip(ICollection<TripDTO> trips)
        {
            bool isValid = true;
            using (var ctx = new StationsContext())
            {
                foreach (var trip in trips)
                {
                    if ((trip.Train == null)
                        || (trip.OriginStation == null)
                        || (trip.DestinationStation == null)
                        || (trip.DepartureTime == null)
                        || (trip.ArrivalTime == null))
                    {
                        isValid = false;
                    }
                    if ((trip.Status != null)
                        && ((trip.Status != "OnTime")
                            && (trip.Status != "Delayed")
                            && (trip.Status != "Early")))
                    {
                        isValid = false;
                    }
                    if (ctx.Trains
                           .Where(tr => tr.TrainNumber == trip.Train)
                           .FirstOrDefault() == null)
                    {
                        isValid = false;
                    }
                    if ((ctx.Stations
                           .Where(st =>st.Name == trip.OriginStation.Name)
                           .FirstOrDefault() == null)
                           ||(ctx.Stations
                           .Where(st => st.Name == trip.DestinationStation.Name)
                           .FirstOrDefault() == null))
                    {
                        isValid = false;
                    }
                    if (trip.DepartureTime >= trip.ArrivalTime)
                    {
                        isValid = false;
                    }

                    if (isValid == false)
                    {
                        Console.WriteLine("Invalid data format.");
                    }
                    else
                    {
                        var thisTrip = new Trip();
                        thisTrip.StationOfOrigin = trip.OriginStation;
                        thisTrip.StationOfOrigin = trip.DestinationStation;
                        thisTrip.Train = ctx.Trains
                                            .Where(tr => tr.TrainNumber == trip.Train)
                                            .SingleOrDefault();
                        thisTrip.DepartureTime = trip.DepartureTime;
                        thisTrip.ArrivalTime = trip.ArrivalTime;
                        thisTrip.Status = trip.Status;
                        ctx.Trips.Add(thisTrip);
                    }
                }
                ctx.SaveChanges();
            }
        }
    }
}
