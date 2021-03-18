using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriveName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PicUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
