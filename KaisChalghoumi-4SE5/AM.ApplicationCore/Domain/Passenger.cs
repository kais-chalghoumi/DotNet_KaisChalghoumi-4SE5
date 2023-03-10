using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        
        public int passengerId { get; set; }

        [DisplayName("Date of Birth")]
        [EmailAddress]//[DataType(DataType.EmailAddress]
        public DateTime birthDate { get; set; }
        // ki tabda tahkilha f haja 
        [MinLength(3,ErrorMessage ="First Name must contains 3 characters(Minimum")]
        [MaxLength(25,ErrorMessage ="First Name must contains 25 characters (Maximum)")]
        //public string firstName { get; set; }
        //public string lastName { get; set; }

        public FullName FullName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string emailAdress { get; set; }

        [StringLength(8,ErrorMessage ="Invalid telephone number")]
        public string telNumber { get; set; }

        [Key]
        [StringLength(7)]
        public string passportNumber { get; set; }

        public List<Ticket> tickets { get; set; }

        //public List<Flight> flights { get; set; }

        //public override string ToString()
        //{
        //    return birthDate + " " + firstName + " " + lastName + " " +  emailAdress + " " + telNumber + " " + passportNumber + " " + flights;
        //}

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

        //public bool CheckProfile(string fName, string lName, string email=null)
        //{
        //    if (email==null)
        //        return fName == firstName && lName == lastName;

        //    return fName == firstName && lName == lastName && email == emailAdress;
        //}

        public virtual void PassengerType()
        {
            Console.WriteLine("I am passenger");
        }

    }
}
