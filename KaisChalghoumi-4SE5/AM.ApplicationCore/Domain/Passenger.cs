using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int passengerId { get; set; }

        [Display(Name = "Date of Birth"), DataType(DataType.Date)]
        public DateTime birthDate { get; set; }

        [MinLength(3, ErrorMessage = "Error !!!"), MaxLength(25, ErrorMessage = "Error !!!")]
        public string firstName { get; set; }

        public string lastName { get; set; }

        [DataType(DataType.EmailAddress)] // = [EmailAddress]
        public string emailAdress { get; set; }

        [MinLength(8), MaxLength(8)]  //  [RegularExpression("[0-9]{8}")]   fi cas tabda numero String
        public string telNumber { get; set; }

        [Key, StringLength(7)]
        public string passportNumber { get; set; }

        public List<Flight> flights { get; set; }

        public override string ToString()
        {
            return birthDate + " " + firstName + " " + lastName + " " + emailAdress + " " + telNumber + " " + passportNumber + " " + flights;
        }

        /*
        public bool CheckProfile(string fName, string lName)
        {
            return fName == firstName && lName == lastName;
        }
        public bool CheckProfile(string fName, string lName, string email)
        {
            return fName == firstName && lName == lastName && email == emailAdress;
        }
        */

        public bool CheckProfile(string fName, string lName, string email = null)
        {
            if (email == null)
                return fName == firstName && lName == lastName;

            return fName == firstName && lName == lastName && email == emailAdress;
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am passenger");
        }

    }
}
