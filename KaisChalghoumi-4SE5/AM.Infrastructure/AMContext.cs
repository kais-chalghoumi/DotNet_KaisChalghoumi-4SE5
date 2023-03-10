using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Flight> Flights {get;set;}
        public DbSet<Passenger> Passengers {get;set;}
        public DbSet<Plane> Planes {get;set;}
        public DbSet<Staff> Staffs {get;set;}
        public DbSet<Traveller> Travellers {get;set;}
        //public DbSet<Test2> test2s { get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localDB)\MsSqlLocalDB; initial catalog = AchrefZitounNet; Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlighConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.Entity<Passenger>().ToTable(nameof(Passengers));
            modelBuilder.Entity<Staff>().ToTable(nameof(Staffs));
            modelBuilder.Entity<Traveller>().ToTable(nameof(Travellers));
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveMaxLength(120);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            //configurationBuilder.Properties<Double>().HaveColumnType("real").HavePrecision(2, 3);
        }

        
    }
}
