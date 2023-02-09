using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; }=new List<Flight>();
        
        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> dates = new List<DateTime>();
            //for(int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination==destination)
            //        dates.Add(Flights[i].FlightDate);
            //}
            //return dates;
            List<DateTime> dates = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination==destination)
                {
                    dates.Add(flight.FlightDate);
                }
               
            }
            return dates;
        }
        public void GetFlights(string filterType, string filterValue)
        {
            List<Flight> list = new List<Flight>();
            switch (filterType)
            {
                case "Destination":
                    var filteredFlights = Flights.Where(f => f.Destination == filterValue);
                    DisplayFlights(filteredFlights);
                    break;

                case "Plane":
                    filteredFlights = Flights.Where(f => f.Plane = filterValue);
                    DisplayFlights(filteredFlights);
                    break;

                case "EffectiveArrival":
                    filteredFlights = Flights.Where(f => f.EffectiveArrival = filterValue);
                    DisplayFlights(filteredFlights);
                    break;

                case "EstimationDuration":
                    filteredFlights = Flights.Where(f => f.EstimationDuration = filterValue);
                    DisplayFlights(filteredFlights);
                    break;

                case "FlightDate":
                    filteredFlights = Flights.Where(f => f.FlightDate = filterValue);
                    DisplayFlights(filteredFlights);
                    break;

                default:
                    Console.WriteLine("Invalid filter type");
                    break;
            }
        }
        private void DisplayFlights(IEnumerable<Flight> flights)
        {
            foreach (var flight in flights)
            {
                Console.WriteLine("EffectiveArrival: " + flight.EffectiveArrival);
                Console.WriteLine("Plane: " + flight.Plane);
                Console.WriteLine("Destination: " + flight.Destination);
                Console.WriteLine("EstimationDuration: " + flight.EstimationDuration);
                Console.WriteLine("FlightDate: " + flight.FlightDate);
                Console.WriteLine();
            }
        }

    }
}

