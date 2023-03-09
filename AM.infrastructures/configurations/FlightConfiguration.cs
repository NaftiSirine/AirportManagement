using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infrastructures.configurations
{
    public class FlightConfiguration:IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            // changement du nom du table associative
            builder.HasMany(f => f.Passengers).WithMany(p=>p.Flights)
                .UsingEntity(p=> p.ToTable("Vols"));

            //config 1 to many en changeant le nom de fk
            builder.HasOne(f => f.Plane).WithMany(p => p.Flights).
                HasForeignKey(p=>p.PlaneFk)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
