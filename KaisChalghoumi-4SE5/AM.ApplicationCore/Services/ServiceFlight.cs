using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger passenger)
        {
            passenger.firstName = passenger.firstName[0].ToString().ToUpper() + passenger.firstName.Substring(1);

            passenger.lastName = passenger.lastName[0].ToString().ToUpper() + passenger.lastName.Substring(1);
        }
    }
}
