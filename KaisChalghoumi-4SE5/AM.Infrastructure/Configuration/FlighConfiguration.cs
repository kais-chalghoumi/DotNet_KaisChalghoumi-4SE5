using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class FlighConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.flightId);
            builder.ToTable("MyFlight"); // configuration nahat l configuration du pre-convention
            builder.Property(f => f.departure).IsRequired().HasMaxLength(100).HasColumnName("Depart").HasDefaultValue("Tunis").HasColumnType("nchar");
            builder.HasOne(f => f.plane).WithMany(p => p.flights).HasForeignKey(f => f.planeFk).OnDelete(DeleteBehavior.SetNull);
            //builder.HasMany(f => f.passengers).WithMany(c => c.flights).UsingEntity(p => p.ToTable("MyReservation"));
        }
    }
}

