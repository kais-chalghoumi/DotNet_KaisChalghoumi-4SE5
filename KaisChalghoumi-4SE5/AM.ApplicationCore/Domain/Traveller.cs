using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string healthInfomation { get; set; }
        public string nationality { get; set; }

        public override string ToString()
        {
            return healthInfomation + " " + nationality;
        }

        public override void PassengerType()
        {
            base.PassengerType();  
            Console.WriteLine("I am passenger I am a traveller");
        }
    }
}
