using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> planes { get; set; } = new List<Plane>()
        {
            new Plane()
            {
                planeId= 1,
                capacity= 150,
                planeType=PlaneType.Boing,
                manufactureDate=new DateTime(2015, 02, 03)
            },
            new Plane()
            {
                planeId= 2,
                capacity= 250,
                planeType=PlaneType.Airbus,
                manufactureDate=new DateTime(2020, 11, 11)
            },

        };


        public static List<Staff> staff { get; set; } = new List<Staff>()
        {
            new Staff()
            {
                firstName = "captain",
                lastName = "captain",
                emailAdress="Captain.captain@gmail.com",
                birthDate=new DateTime(1965, 01, 01),
                employementDate=new DateTime(1999, 01, 01),
                salary=99999
            },
            new Staff()
            {
                firstName = "hostess1",
                lastName = "hostess1",
                emailAdress="Hostess1.hostess1@gmail.com",
                birthDate=new DateTime(1995, 01, 01),
                employementDate=new DateTime(2020, 01, 01),
                salary=999
            },
            new Staff()
            {
                firstName = "hostess2",
                lastName = "hostess2",
                emailAdress="Hostess2.hostess2@gmail.com",
                birthDate=new DateTime(1996, 01, 01),
                employementDate=new DateTime(2020, 01, 01),
                salary=999
            }
        };

        public static List<Traveller> travellers { get; set; } = new List<Traveller>()
        {
           new Traveller()
           {
               firstName="Travaller1",
               lastName="Travaller1",
               emailAdress="Travaller1.Travaller1@gmail.com",
               birthDate=new DateTime(1980, 01, 01),
               healthInfomation="No troubles",
               nationality="American"
           },
           new Traveller()
           {
               firstName="Travaller2",
               lastName="Travaller2",
               emailAdress="Travaller2.Travaller2@gmail.com",
               birthDate=new DateTime(1981, 01, 01),
               healthInfomation="Some troubles",
               nationality="French"
           },
           new Traveller()
           {
               firstName="Travaller3",
               lastName="Travaller3",
               emailAdress="Travaller3.Travaller3@gmail.com",
               birthDate=new DateTime(1982, 01, 01),
               healthInfomation="No troubles",
               nationality="Tunisian"
           },
           new Traveller()
           {
               firstName="Travaller4",
               lastName="Travaller4",
               emailAdress="Travaller4.Travaller4@gmail.com",
               birthDate=new DateTime(1983, 01, 01),
               healthInfomation="Some troubles",
               nationality="American"
           },
           new Traveller()
           {
               firstName="Travaller5",
               lastName="Travaller5",
               emailAdress="Travaller5.Travaller5@gmail.com",
               birthDate=new DateTime(1984, 01, 01),
               healthInfomation="Some troubles",
               nationality="Spanish"
           }
        };

        public static List<Flight> flights { get; set; } = new List<Flight>()
        {
            new Flight() 
            {
                flightDate=new DateTime(2022, 01, 01, 15, 10, 10),
                destination="Paris",
                effectiveArrival=new DateTime(2022, 01, 01, 17, 10, 10),
                plane = planes[1],
                estimatedDuration=100,
                passengers=new List<Passenger>(travellers)
            },
            new Flight()
            {
                flightDate=new DateTime(2022, 02, 01, 21, 10, 10),
                destination="Paris",
                effectiveArrival=new DateTime(2022, 02, 01, 23, 10, 10),
                plane = planes[0],
                estimatedDuration=105,
            },
            new Flight()
            {
                flightDate=new DateTime(2022, 03, 01, 5, 10, 10),
                destination="Paris",
                effectiveArrival=new DateTime(2022, 03, 01, 6, 40, 10),
                plane = planes[0],
                estimatedDuration=100,
            },
            new Flight()
            {
                flightDate=new DateTime(2022, 04, 01, 6, 10, 10),
                destination="Madrid",
                effectiveArrival=new DateTime(2022, 04, 01, 8, 10, 10),
                plane = planes[0],
                estimatedDuration=130,
            },
            new Flight()
            {
                flightDate=new DateTime(2022, 05, 01, 17, 10, 10),
                destination="Madrid",
                effectiveArrival=new DateTime(2022, 05, 01, 18, 50, 10),
                plane = planes[0],
                estimatedDuration=105,
            }
            ,new Flight()
            {
                flightDate=new DateTime(2022, 06, 01, 20, 10, 10),
                destination="Lisbonne",
                effectiveArrival=new DateTime(2022, 06, 01, 22, 30, 10),
                plane = planes[1],
                estimatedDuration=200,
            }
        };



    }
}
