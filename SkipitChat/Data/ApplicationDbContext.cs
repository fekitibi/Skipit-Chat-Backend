using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkipitChat.Domain;

namespace SkipitChat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<CityPass> CityPasses { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Accessibility> Accessiblities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Accessibility>()
                .HasData(
                    new Accessibility
                    {
                        Id = Guid.NewGuid(),
                        StationName = "Station 1",
                        Elevator = true,
                        DisabledService = true,
                        Stairs = true,
                        Escalator = true,
                        Toilet = true,
                        WaitingRoom = true,
                        BikeParking = true,
                        TicketMachine = true,
                        Comment = "",
                    },
                    new Accessibility
                    {
                        Id = Guid.NewGuid(),
                        StationName = "Station 2",
                        Elevator = false,
                        DisabledService = false,
                        Stairs = false,
                        Escalator = false,
                        Toilet = false,
                        WaitingRoom = false,
                        BikeParking = false,
                        TicketMachine = false,
                        Comment = "",
                    },
                    new Accessibility
                    {
                        Id = Guid.NewGuid(),
                        StationName = "Station 3",
                        Elevator = true,
                        DisabledService = false,
                        Stairs = false,
                        Escalator = false,
                        Toilet = true,
                        WaitingRoom = false,
                        BikeParking = false,
                        TicketMachine = true,
                        Comment = "",
                    }
                );


            modelBuilder.Entity<CityPass>()
                .HasData(
                    new CityPass
                    {
                        Id = Guid.NewGuid(),
                        DurationInHour= 244 ,
                        CityPass4Price = 2345,
                        CityPass99Price=3000
                    },
                    new CityPass
                    {
                        Id = Guid.NewGuid(),
                        DurationInHour = 4,
                        CityPass4Price = 55,
                        CityPass99Price = 90

                    },
                    new CityPass
                    {
                        Id = Guid.NewGuid(),
                        DurationInHour = 24,
                        CityPass4Price = 599,
                        CityPass99Price = 700

                    }
                );

            modelBuilder.Entity<Zone>()
                .HasData(
                    new Zone
                    {
                        Id = 2,
                        DurationInMinute = 120,
                        PriceChildren = 5,
                        PriceDisabled = 5,
                        PriceAdult = 10,
                        PriceElderly = 5, 
                        Animal = 20,
                        Bycicle = 20,
                    },
                    new Zone
                    {
                        Id = 3,
                        DurationInMinute = 170,
                        PriceChildren = 4,
                        PriceDisabled = 5,
                        PriceAdult = 6,
                        PriceElderly = 7,
                        Animal = 20,
                        Bycicle = 9,

                    },
                    new Zone
                    {
                        Id = 4,
                        DurationInMinute = 120,
                        PriceChildren = 7,
                        PriceDisabled = 5,
                        PriceAdult = 17,
                        PriceElderly = 7,
                        Animal = 20,
                        Bycicle = 20,

                    }
                );
        }
    }
}
