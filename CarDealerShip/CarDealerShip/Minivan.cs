using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class Minivan : Vehicle
    {
        public Minivan(int price, string make)
        {
            this.price = price;
            this.make = make;
            hasBeenTested = false;
        }
    }
}
