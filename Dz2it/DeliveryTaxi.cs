using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2it
{
    class DeliveryTaxi : Taxi
    {
        public int CarryingCapacity { get; private set; }
        public DeliveryTaxi(string Brand, double PricePerTrip, double Consumption, double Power, double CarPrice, int CarryingCapacity)
        : base(Brand, PricePerTrip, Consumption, Power, CarPrice)
        {
            this.CarryingCapacity = CarryingCapacity;
        }
    }
}
