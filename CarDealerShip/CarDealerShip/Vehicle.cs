using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CarDealerShip
{
    public class Vehicle : IDrivible
    {
        public int price;
        public string make;
        public bool hasBeenTested = false;
        public void takeForTestDrive()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vroom vroom! The customer took out the Vehicle for a test!");
            for (int i = 0; i < 7; i++)
            {
                Thread.Sleep(200);
                Console.Write(". ");
            }

            Console.WriteLine("\n\rThe customer took it back to the lot!");
        }
    }
}
