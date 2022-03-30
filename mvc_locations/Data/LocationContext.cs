using Microsoft.EntityFrameworkCore;
using mvc_locations.Models;

namespace mvc_locations.Data
{
    public class LocationContext : DbContext
    {

        public LocationContext(DbContextOptions<LocationContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        // Zadatak:
        // kreirati metodu OnModelCreating(ModelBuilder modelBuilder)
        // Napraviti seed podataka za:
        // Minimalno dvije nasumične države s pripadajućim podacima
        // minimalno šest nasumičnih gradova s pripadajućim podacima

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //prvo popunjavamo obične tablice a nakon toga ove sa vezama
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    id = 1,
                    country_name = "Hrvatska",
                    country_name_eng = "Croatia",
                    country_code="+385"
                },
                 new Country
                 {
                     id = 2,
                     country_name = "Francuska",
                     country_name_eng = "France",
                     country_code = "+33"
                 },
                  new Country
                  {
                      id = 3,
                      country_name = "Brazil",
                      country_name_eng = "Brazil",
                      country_code = "+55"
                  }
            );
            modelBuilder.Entity<City>().HasData(
                new City
                    {
                        id = 1,
                        city_name = "Đakovo",
                        latitude = 45.3100M,
                        longitude = 18.4098M,
                        country_id = 1
                    },
                new City
                {
                    id = 2,
                    city_name = "Split",
                    latitude = 43.5147M,
                    longitude = 16.4435M,
                    country_id = 1
                },
                 new City
                 {
                     id = 3,
                     city_name = "São Paulo",
                     latitude = 23.5558M,
                     longitude = 46.6396M,
                     country_id = 3
                 },
                  new City
                  {
                      id = 4,
                      city_name = "Rio de Janeiro",
                      latitude = 22.9068M,
                      longitude = 43.1729M,
                      country_id = 3
                  },
                   new City
                   {
                       id = 5,
                       city_name = "Marseille",
                       latitude = 43.2965M,
                       longitude = 5.3698M,
                       country_id = 2
                   },
                    new City
                    {
                        id = 6,
                        city_name = "Lille",
                        latitude = 50.6292M,
                        longitude = 3.0573M,
                        country_id = 2
                    }
            );
        }


    }
}
