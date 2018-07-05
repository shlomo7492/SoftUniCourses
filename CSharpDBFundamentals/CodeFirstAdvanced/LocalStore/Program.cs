using LocalStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalStore
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalStoreContext context = new LocalStoreContext();

            Product milk = new Product("Milk","Serdika OOD","Caw's milk",4,3,2.00m);
            //Product cheese = new Product("White feta cheese", "Himko OOD", "White feta cheese from caw's milk", 25.00m);
            //Product salam = new Product("Smocked game meat salami","Messtrans EOOD","Best quality salamy from organic meat from deers and wild boars", 23.00m );
            //Product vino = new Product("Red wine", "Kruchmata EOOD", "Best quality red wine from Tracian valley", 23.00m);

            context.Products.Add(milk);
            //context.Products.Add(cheese);
            //context.Products.Add(salam);
            //context.Products.Add(vino);


            context.SaveChanges();
        }
    }
}
