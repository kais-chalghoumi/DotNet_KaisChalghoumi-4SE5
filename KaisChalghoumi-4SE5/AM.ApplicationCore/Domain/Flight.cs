using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string destination { get; set; }
        public string departure { get; set; }
        public DateTime flightDate { get; set; }
        public int flightId { get; set; }
        public DateTime effectiveArrival { get; set; }
        public int estimatedDuration { get; set; }
        public List<Passenger> passengers { get; set; }
        public Plane? plane { get; set; } //propritete de navigation (relation) !!!

        [ForeignKey(nameof(plane))]
        public int? PlaneFK { get; set; }

        public override string ToString()
        {
            return destination + " " + departure + " " + flightDate + " " + effectiveArrival + " " + estimatedDuration
                + " " + passengers + " " + plane;
        }
    }
}
