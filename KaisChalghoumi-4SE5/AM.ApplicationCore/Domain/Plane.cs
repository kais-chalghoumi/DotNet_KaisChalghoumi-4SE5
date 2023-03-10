using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        [Range(0,int.MaxValue)]
        public int capacity { get; set; }
        public int planeId { get; set; }
        public PlaneType planeType { get; set;}
        public DateTime manufactureDate { get; set; }
        public ICollection<Flight> flights { get; set; }

        public override string ToString()
        {
            return capacity + " " + planeId + " " + planeType + " " + manufactureDate + " " + flights;
        }

        /*
        public Plane(PlaneType pt, int capacity, DateTime ManufactureDate)
        {
            this.capacity = capacity;
            this.manufactureDate= ManufactureDate;
            this.planeType = pt;
        }*/
    }
}
