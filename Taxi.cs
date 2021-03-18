using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_taxi
{
    class Taxi
    {        //properties
        public string DriveName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name \t\t: {0}", DriveName);
            Console.WriteLine("On Duty \t\t: {0}", OnDuty);
            Console.WriteLine("Number of Passenger \t: {0}\n", NumPassenger);
            
        }

        public void PicUpPassenger()
        {
             Console.WriteLine("{0} sedang menjemput penumang", DriveName);
            
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang", DriveName);
        }
    }
}
