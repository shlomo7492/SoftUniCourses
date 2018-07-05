using Data.DTOS.Imports;
using Data.Stores;
using DomainModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationsImport
{
    public class JasonImport
    {
        public static void ImportStation()
        {
            var json = File.ReadAllText("../../../Resources/stations.json");
            var stations = JsonConvert.DeserializeObject<ICollection<Station>>(json);

            StationStore.AddStation(stations);
        }
        public static void ImportSeatingClass()
        {
            var json = File.ReadAllText("../../../Resources/classes.json");
            var seatClases = JsonConvert.DeserializeObject<ICollection<SeatingClass>>(json);

            SeatingClassStore.AddSeatingClass(seatClases);
        }
        public static void ImportTrain()
        {
            var json = File.ReadAllText("../../../Resources/trains.json");
            var trainDTOs = JsonConvert.DeserializeObject<ICollection<TrainSeatsDTO>>(json);

            TrainStore.AddTrain(trainDTOs);
        }
        public static void ImportTrip()
        {
            var json = File.ReadAllText("../../../Resources/trips.json");
            var tripDTOs = JsonConvert.DeserializeObject<ICollection<TripDTO>>(json);

            TripStore.AddTrip(tripDTOs);
        }
    }
}
