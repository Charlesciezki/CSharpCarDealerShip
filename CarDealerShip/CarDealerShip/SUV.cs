using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class SUV : Vehicle
    {
        public SUV(int price, string make)
        {
            this.price = price;
            this.make = make;
            hasBeenTested = false;
        }
        
    }
}
