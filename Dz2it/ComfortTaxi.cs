using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2it
{
    public class ComfortTaxi : Taxi
    {
        public int VehicleAge { get; private set; }
        public ComfortTaxi(string Brand, double PricePerTrip, double Consumption, double Power, double CarPrice, int VehicleAge)
        : base(Brand, PricePerTrip, Consumption, Power, CarPrice)
        {
            this.VehicleAge = VehicleAge;
        }
    }
}
