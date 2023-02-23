using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime employementDate{ get; set; }
        public string function { get; set; }
        public float salary { get; set; }

        public override string ToString()
        {
            return employementDate + " " + function + " " + salary;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am passenger I am a staff member");
        }
    }
}
