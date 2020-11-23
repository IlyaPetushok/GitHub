using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2it
{
    public class TaxiStation : ITaxiStation
    {
        private readonly List<Taxi> cars;
        public TaxiStation()
        {
            cars = new List<Taxi>();
        }
        public void Add(Taxi _car)
        {
            cars.Add(_car);
        }
        public IEnumerable<Taxi> Items
        {
            get { return cars; }
        }
        readonly List<Taxi> temp = new List<Taxi>();
        public IEnumerable<Taxi> FindCaryByPower(int _min, int _max)
        {
            foreach (var car in cars)
            {
                if (car.Power >= _min && car.Power <= _max)
                {
                    temp.Add(car);
                }
            }
            return temp;
        }
        public void SortByСonsumption()
        {
            var array = cars.ToList();
            Taxi temp;
            for (var i = 1; i < 4; i++)
            {
                for (var j = 0; j < 4 - i; j++)
                {
                    if (array[j].Consumption > array[j + 1].Consumption)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            cars.Clear();
            foreach (var item in array)
            {
                cars.Add(item);
            }
        }
        public void TaxiStationPrint()
        {
            foreach (var car in cars)
            {
                Console.WriteLine("Brand of the car:" + car.Brand);
                Console.WriteLine("PricePerTrip:" + car.PricePerTrip);
                Console.WriteLine("Consumption:" + car.Consumption);
                Console.WriteLine("Consumption:" + car.Power);
                Console.WriteLine("CarPrice" + car.CarPrice);
            }
        }
    }
}
