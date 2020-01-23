using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAirport.Models;

namespace WebAirport.Data
{
    public class AirportContext : DbContext
    {
        public AirportContext() : base("BaseAirport") { }

        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<JobAirplane> JobAirplanes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TypeAirplane> TypeAirplanes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Position>().
                HasMany(c => c.Staffs).
                WithRequired(o => o.Position);

            modelBuilder.Entity<Airplane>().
                HasMany(c => c.Flights).
                WithRequired(o => o.Airplane);

            modelBuilder.Entity<TypeAirplane>().
                HasMany(c => c.JobAirplanes).
                WithRequired(o => o.TypeAirplane);

            modelBuilder.Entity<JobAirplane>().
                HasMany(c => c.Airplanes).
                WithRequired(o => o.JobAirplane);

            modelBuilder.Entity<Airplane>().
                HasMany(c => c.Flights).
                WithRequired(o => o.Airplane);

            modelBuilder.Entity<Flight>().
                HasMany(c => c.Tickets).
                WithRequired(o => o.Flight);*/

            base.OnModelCreating(modelBuilder);
        }
    }
}