namespace Data
{
    using DomainModels;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StationsContext : DbContext
    {
        public StationsContext()
            : base("name=StationsContext")
        {
        }

        
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        public virtual DbSet<SeatingClass> SeatingClasses { get; set; }
        public virtual DbSet<TrainSeats> TrainsSeats { get; set; }

        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<CustomerCard> CustomersCards { get; set; }

    }


}