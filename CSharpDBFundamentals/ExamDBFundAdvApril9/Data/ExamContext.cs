namespace Data
{
    using DomainModels;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ExamContext : DbContext
    {
        public ExamContext()
            : base("name=ExamContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Discovery>()
                .HasMany(d => d.Pioneers)
                .WithMany(p => p.PioneeringDiscoveries)
                .Map(dp =>
                {
                    dp.ToTable("Pioneers");
                    dp.MapLeftKey("DiscoveryId");
                    dp.MapRightKey("AstronomerId");
                });
            modelBuilder.Entity<Discovery>()
               .HasMany(d => d.Observers)
               .WithMany(p => p.ObservedDiscoveries)
               .Map(dp =>
               {
                   dp.ToTable("Observers");
                   dp.MapLeftKey("DiscoveryId");
                   dp.MapRightKey("AstronomerId");
               });
        }
        public virtual DbSet<Astronomer> Astronomers { get; set; }
        public virtual DbSet<Discovery> Discoveries { get; set; }
        public virtual DbSet<Telescope> Telescopes { get; set; }
        public virtual DbSet<Star> Stars { get; set; }
        public virtual DbSet<Planet> Planets { get; set; }
        public virtual DbSet<StarSystem> StarSystems { get; set; }





    }


}