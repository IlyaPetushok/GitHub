using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2it
{
    public class EconomyTaxi : Taxi
    {
        public string CarClass { get; private set; }
        public EconomyTaxi(string Brand, double PricePerTrip, double Consumption, double Power, double CarPrice, string CarClass)
        : base(Brand, PricePerTrip, Consumption, Power, CarPrice)
        {
            this.CarClass = CarClass;
        }
    }
}
