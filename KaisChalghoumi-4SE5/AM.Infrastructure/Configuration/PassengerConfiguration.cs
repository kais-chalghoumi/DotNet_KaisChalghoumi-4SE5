using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    internal class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {

            builder.OwnsOne(e => e.FullName, F=>
            {
                F.Property(p => p.FirstName).IsRequired().HasMaxLength(30).HasColumnName("firstName");
                F.Property(p => p.LastName).IsRequired().HasMaxLength(30).HasColumnName("lastName");
            });

            builder.HasDiscriminator<int>("type").HasValue< Passenger>(0).HasValue<Staff>(1).HasValue<Traveller>(2);

        }
    }
}