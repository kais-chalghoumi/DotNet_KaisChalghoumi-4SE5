using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System.Collections;
using System.Collections.Generic;
using static AM.ApplicationCore.Services.ServiceFlight;


// 7-
Plane plane = new Plane();
//plane.planeId = 1;
//plane.capacity = 500;
//plane.planeType = PlaneType.Airbus;
//plane.manufactureDate = new DateTime(2023, 05, 02);
//Un erreur se produit aprés la création d'un constructeur paramétrés

// 8- Création d'un constructeur

// 9-
//Plane plane2 = new Plane(PlaneType.Boing,480,new DateTime(2023, 04, 30));
//Un erreur se produit aprés la suppresion du constructeur crée au niveau de la question 8
//Plane plane3 = new Plane
//{
//    planeId = 1,
//    capacity = 1,
//    manufactureDate = new DateTime(2023, 04, 12),
//    planeType = PlaneType.Airbus
//};

// 10 - Création des méthode checkprofile();

// 11 -
//Passenger p = new Passenger();
//p.PassengerType();

//Staff s = new Staff();
//s.PassengerType();

//Traveller t = new Traveller();
//t.PassengerType();


// ------------------------------------------------------------------------
//TP2 
// 5

ServiceFlight serviceFlight = new ServiceFlight();
serviceFlight.Flights = TestData.flights;

/*
serviceFlight.GetFlights("Paris",delegate(Flight f, String c)
{
    return f.destination == c;
});

serviceFlight.GetFlights("2023/01/01", (Flight f, String c) =>
{
    return f.flightDate.Equals(c);
});
*/



Action<Plane> FlightDetailsDel = serviceFlight.ShowFlightDetails;
FlightDetailsDel(TestData.planes[1]);

Func<String,double> DurationAverageDel = serviceFlight.DurationAverage;
Console.WriteLine(DurationAverageDel("Paris"));

FlightDetailsDel = Plane => serviceFlight.ShowFlightDetails(TestData.planes[1]);

DurationAverageDel = flightList => TestData.flights.Average(flight => flight.estimatedDuration);



