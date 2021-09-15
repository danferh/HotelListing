using HotelListing.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());

            builder.Entity<Country>().HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Jamaica",
                        ShortName = "JM"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Bahamas",
                        ShortName = "BS"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Cayman Island",
                        ShortName = "CI"
                    },
                    new Country
                    {
                        Id = 4,
                        Name = "United States",
                        ShortName = "US"
                    },
                    new Country
                    {
                        Id = 5,
                        Name = "Nicaragua",
                        ShortName = "NI"
                    }
                );

            builder.Entity<Hotel>().HasData(
                    new Hotel
                    {
                        Id = 1,
                        Name = "Sandals Resort and Spa",
                        Address = "Negrill",
                        CountryId = 1,
                        Rating = (decimal)4.5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Comfort Suites",
                        Address = "George Town",
                        CountryId = 3,
                        Rating = (decimal)4.3
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Grand Palladium",
                        Address = "Nassua",
                        CountryId = 2,
                        Rating = (decimal)4
                    },
                    new Hotel
                    {
                        Id = 4,
                        Name = "Hilton",
                        Address = "Managua",
                        CountryId = 5,
                        Rating = (decimal)4.3
                    },
                    new Hotel
                    {
                        Id = 5,
                        Name = "Hilton",
                        Address = "Miami",
                        CountryId = 4,
                        Rating = (decimal)4
                    }
                );
            base.OnModelCreating(builder);
        }       
    }
}
