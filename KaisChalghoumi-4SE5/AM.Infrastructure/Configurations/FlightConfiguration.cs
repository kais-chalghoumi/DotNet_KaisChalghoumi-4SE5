using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.flightId);
            builder.ToTable("MyFlight");
            builder.Property(j => j.departure)
                .IsRequired().HasMaxLength(100)
                .HasColumnName("ville de depart")
                .HasDefaultValue("TUN")
                .HasColumnType("nchar");
        }
    }
}
