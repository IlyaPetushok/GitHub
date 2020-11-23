using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2it
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaxiStation taxiStation = new TaxiStation();
            Taxi auto = new Taxi("Volswagen", 2.60, 8.5, 77, 6500);
            Taxi auto1 = new Taxi("Renaught Logan", 3.0, 6.0, 110, 7000);
            Taxi auto2 = new Taxi("Renaught Duster", 3.50, 7.0, 95, 8000);
            Taxi auto3 = new Taxi("Shloda Rapid", 4.0, 9.0, 130, 9000);
            taxiStation.Add(auto);
            taxiStation.Add(auto1);
            taxiStation.Add(auto2);
            taxiStation.Add(auto3);
            Console.WriteLine("TaxiPark:");
            foreach (var item in taxiStation.Items)
            {
                Console.WriteLine("Brand:"+ item.Brand);
                Console.WriteLine("PricePerTrip:" + item.PricePerTrip);
                Console.WriteLine("Consumption:" + item.Consumption);
                Console.WriteLine("Power:" + item.Power);
                Console.WriteLine("CarPrice:" + item.CarPrice);
            }
            taxiStation.SortByСonsumption();
            Console.WriteLine("Машина по заданной л.с:");
            foreach (var item in taxiStation.FindCaryByPower(90, 120))
            {
                Console.Write("Модель:" + item.Brand);
                Console.WriteLine("Л.с" + item.Power);
            }
        }
    }
}
