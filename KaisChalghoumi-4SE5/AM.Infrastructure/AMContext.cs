using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        //  public DbSet<Staff> Staff {get;set;}
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Test2> test2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localDB)\MsSqlLocalDB; initial catalog = AchrefZitounNet; Integrated Security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().HasKey(f => f.flightId);
            modelBuilder.Entity<Flight>().ToTable("MyFlight");
            modelBuilder.Entity<Flight>().Property(j => j.departure)
                .IsRequired().HasMaxLength(100)
                .HasColumnName("ville de depart")
                .HasDefaultValue("TUN")
                .HasColumnType("nchar");
        }
    }
}
