using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>() {

        new Plane (){
        PlaneType=PlaneType.Boing,
        Capacity=150,
        ManufactureDate=new DateTime(2015,02,03)
        },
        new Plane (){
        PlaneType=PlaneType.Airbus,
        Capacity=250,ManufactureDate=new DateTime(2020,11,11)

        }

        };
        public static List<Staff> Staff { get; set; } = new List<Staff>() {
        new Staff()
        {
            FirstName="captain",
            LastName="capitain",
            EmailAddress="Captain.captain@gmail.com",
            BirthDate=new DateTime(1995,01,01),
            EmployementDate=new DateTime(1999,01,01),
            Salary=99999
        }
        };
        public static List<Traveller> Traveller { get; set; } = new List<Traveller>() {
        new Traveller()
        {
             FirstName="Traveller1",
            LastName="Traveller1",
            EmailAddress="Traveller1.Traveller1@gmail.com",
            BirthDate=new DateTime(1980,01,01),
            HealthInformation="No trouble",
            Nationality="Amercan"
        }
        };
        public static List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight()
            {
                FlightDate=new DateTime(2022,01,01,15,10,10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022, 01, 01, 17, 10, 10),
                Plane= Planes[1],
                EstimationDuration=110,
                Passengers= new List<Passenger>(Traveller),

            }
        };

    }
}
