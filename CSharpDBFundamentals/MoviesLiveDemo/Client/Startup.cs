

namespace Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Models;
    class Startup
    {
        static void Main(string[] args)
        {
            MoviesContext context = new MoviesContext();
            context.Movies.Add(new Movie()
            {
                Title = "Interstellar",
                Genre = "Drama/Adventure/Sci-Fi",
                Rating = 8.6f,
                YearOfRelease = 2014,
                Director = new Director()
                {
                    FirstName = "Christopher",
                    LastName = "Nolan"
                }
            });
            context.SaveChanges();
            
        }
    }
}
