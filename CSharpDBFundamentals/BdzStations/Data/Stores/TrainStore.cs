using Data.DTOS.Imports;
using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Stores
{
    public class TrainStore
    {
        public static void AddTrain(ICollection<TrainSeatsDTO> trains)
        {
            using (var ctx = new StationsContext())
            {
                foreach (var train in trains)
                {
                    bool isValid = true;
                    List<SeatDTO> seatClasNames = new List<SeatDTO>();
                    foreach (var seat in train.Seats)
                    {
                        var seatVal = train.Seats
                            .Where(s => s.SeatClassName == seat.SeatClassName)
                            .SingleOrDefault();
                        bool nameSet = false;

                        foreach (var st in seatClasNames)
                        {
                            if (seat.SeatClassName == st.SeatClassName)
                            {
                                nameSet = true;
                            }
                        }

                        if (!nameSet)
                        {
                            seatClasNames.Add(seat);
                        }

                        if (((seat.SeatClassName == null) || (seat.Abbreviation == null))
                            ||(seat.Abbreviation!=seatVal.Abbreviation)
                            ||(seat.Quantity<=0)
                            ||(nameSet==true))
                            { isValid = false; }
                    }
                              
                   if (((train.Type != null) 
                        && (train.Type != "HighSpeed"
                                || train.Type != "LongDistance"
                                || train.Type != "Freight"))
                                ||(isValid==false))
                    {
                        Console.WriteLine("Invalid data format.");
                    }
                    else
                    {
                        var thisTrain = new Train();
                        thisTrain.TrainNumber = train.TrainTrainNumber;
                        thisTrain.Type = train.Type;
                        //ctx.Trains.Add(thisTrain);

                        var trainSeats = new TrainSeats();
                        trainSeats.Train = thisTrain;
                        foreach (var seat in seatClasNames)
                        {

                            trainSeats.SeatClass = ctx.SeatingClasses
                                               .Where(sc=>sc.Name==seat.SeatClassName)
                                               .SingleOrDefault();
                            trainSeats.Quantity = seat.Quantity;
                            Console.WriteLine($"Record {seat.SeatClassName} successfully imported.");
                        }
                        ctx.TrainsSeats.Add(trainSeats);
                        Console.WriteLine($"Record {trainSeats.Train.TrainNumber} successfully imported.");
                    }


                }
                ctx.SaveChanges();
            }
        }
    }
}
