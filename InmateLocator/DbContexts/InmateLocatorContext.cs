using System;
using InmateLocator.Entities;
using Microsoft.EntityFrameworkCore;

namespace InmateLocator.DbContexts
{
    public class InmateLocatorContext : DbContext
    {
        public InmateLocatorContext(DbContextOptions<InmateLocatorContext> options) : base(options)
        {
        }

        public DbSet<Inmate> Inmates { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy inmate data
            modelBuilder.Entity<Inmate>().HasData(
                new Inmate()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    PID = "123456",
                    FirstName = "Dan",
                    LastName = "Lopez",
                    DateOfBirth = new DateTime(2020, 2, 04)
                },
                new Inmate()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    PID = "598744",
                    FirstName = "Ronald",
                    LastName = "Pax",
                    DateOfBirth = new DateTime(1980, 2, 02)
                },
                new Inmate()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    PID = "732123",
                    FirstName = "Arnold",
                    LastName = "Phillips",
                    DateOfBirth = new DateTime(1950, 9, 11)
                },
                new Inmate()
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    PID = "584123",
                    FirstName = "Brian",
                    LastName = "Dawkins",
                    DateOfBirth = new DateTime(1953, 2, 15)
                },
                new Inmate()
                {
                    Id = Guid.Parse("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                    PID = "852014",
                    FirstName = "Christopher",
                    LastName = "Wallace",
                    DateOfBirth = new DateTime(1993, 7, 21)
                },
                new Inmate()
                {
                    Id = Guid.Parse("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                    PID = "987456",
                    FirstName = "Johnathan",
                    LastName = "Hugh",
                    DateOfBirth = new DateTime(1991, 5, 09)
                },
                new Inmate()
                {
                    Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                    PID = "741258",
                    FirstName = "Rick",
                    LastName = "Flair",
                    DateOfBirth = new DateTime(1968, 3, 29)
                }
                );

            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                    InmateId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    CurrentLocation = "City Hall"
                },
                new Location
                {
                    Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                    InmateId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    CurrentLocation = "City Hall"
                },
                new Location
                {
                    Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                    InmateId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    CurrentLocation = "City Hall"
                },
                new Location
                {
                    Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                    InmateId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    CurrentLocation = "City Hall"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
