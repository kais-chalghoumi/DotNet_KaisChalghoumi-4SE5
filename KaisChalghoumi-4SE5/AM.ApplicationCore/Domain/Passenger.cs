using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PasseportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return FirstName + "" + LastName + "" + BirthDate + "" + PasseportNumber + "" + TelNumber + "" + EmailAddress;
        }

        bool CheckProfile(string firstname, string lastname)
        {
            return FirstName == firstname && LastName == lastname;
        }

        public bool CheckProfile(string firstname, string lastname, string email)
        {
            return CheckProfile(firstname, lastname) && EmailAddress == email;
        }

        public bool Login(string firstname, string lastname, string email = null)
        {
            //if (email!= null) 
            //return CheckProfile(firstname,lastname,email);
            //return FirstName == firstname && LastName == lastname;
            return email != null ? CheckProfile(firstname, lastname, email) : CheckProfile(firstname, lastname);
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I'm Passenger");
        }
    }
}
