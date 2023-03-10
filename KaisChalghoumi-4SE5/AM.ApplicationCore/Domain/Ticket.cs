using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public bool VIP { get; set; }
        public double Prix { get; set; }
        public string Siege { get; set; }
        public Flight flight { get; set; }
        public Passenger passenger { get; set; }
        //[Key]
        [ForeignKey(nameof(flight))]
        public int flightFK { get; set; }
        //[Key]
        [ForeignKey(nameof(passenger))]
        public string passengerFK { get; set; }
    }
}
