using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2it
{
    public  class Taxi
    {
        public string Brand;
        public double PricePerTrip, Consumption, Power, CarPrice;
        public Taxi(string Brand, double PricePerTrip, double Consumption, double Power, double CarPrice)
        {
            this.Brand = Brand;
            this.PricePerTrip = PricePerTrip;
            this.Consumption = Consumption;
            this.Power = Power;
            this.CarPrice = CarPrice;
        }
    }
}
