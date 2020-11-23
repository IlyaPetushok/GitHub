using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2it
{
   public interface ITaxiStation
    {
        IEnumerable<Taxi> Items { get; }
        IEnumerable<Taxi> FindCaryByPower(int _min, int _max);
        void Add(Taxi _car);
        void SortByСonsumption();
        void TaxiStationPrint();
    }
}
