using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationsImport
{
    class Startup
    {
        static void Main(string[] args)
        {
            JasonImport.ImportStation();
            JasonImport.ImportSeatingClass();
            JasonImport.ImportTrain();
            JasonImport.ImportTrip();
        }
    }
}
