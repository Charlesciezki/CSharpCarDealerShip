using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class CarDealership
    {
        public Minivan miniVan = new Minivan(15000, "Toyota");
        public PickUp pickUp = new PickUp(17000, "Ford");
        public Sedan sedan = new Sedan(20000, "Audi");
        public SportsCar sportsCar = new SportsCar(18000, "Lexus");
        public SUV suv = new SUV(19000, "GMC");
        public List<Vehicle> carLot = new List<Vehicle>();

        public CarDealership()
        {
            carLot.Add(miniVan);
            carLot.Add(pickUp);
            carLot.Add(sedan);
            carLot.Add(sportsCar);
            carLot.Add(suv);
        }

        public void orderCars()
        {
            carLot.Add(miniVan);
            carLot.Add(pickUp);
            carLot.Add(sedan);
            carLot.Add(sportsCar);
            carLot.Add(suv);
            Console.WriteLine("A Minivan, PickUp, Sedan, Sports Car, and an SUV have been added to the lot!");
        }
        public int specialOrderCars()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to VehicleOrder.Com What kind of Vehicle would you like?");
            Console.WriteLine("We have Minivans, Pickups, Sedans, Sports Cars, and SUVs, enter below what you'd like!");
            string vehicleChoice = Console.ReadLine().ToLower();
            if (vehicleChoice == "minivan")
            {
                orderMiniVan();
            } else if (vehicleChoice == "pickup")
            {
                orderPickUp();
            } else if (vehicleChoice == "sedan")
            {
                orderSedan();
            } else if (vehicleChoice == "sports car")
            {
                orderSportsCar();
            } else if (vehicleChoice == "suv")
            {
                orderSUV();
            }
            else
            {
                return specialOrderCars();
            }
            return 1;
        }

        public int orderMiniVan()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello! What make of MiniVan do you need today? We have Toyota, GMC, and NASCAR");
            string make = Console.ReadLine().ToLower();
            if (make == "toyota")
            {
               carLot.Add(new Minivan(15000, make));
            } else if (make == "GMC")
            {
                carLot.Add(new Minivan(15000, make));
            } else if (make == "nascar")
            {
                carLot.Add(new Minivan(15000, make));
            }
            else
            {
                return orderMiniVan();
            }
            Console.WriteLine("Minivan added!");
            return 1;
        }

        public int orderPickUp()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello! What make of PickUp do you need today? We have Ford, GMC, and Toyota");
            string make = Console.ReadLine().ToLower();
            if (make == "ford")
            {
                carLot.Add(new PickUp(17000, make));
            }
            else if (make == "GMC")
            {
                carLot.Add(new PickUp(17000, make));
            }
            else if (make == "toyota")
            {
                carLot.Add(new PickUp(17000, make));
            }
            else
            {
                return orderPickUp();
            }
            Console.WriteLine("Pickup added!");
            return 1;
        }

        public int orderSedan()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Hello! What make of Sedan do you need today? We have Toyota, Audi, and Honda");
            string make = Console.ReadLine().ToLower();
            if (make == "toyota")
            {
                carLot.Add(new Sedan(20000, make));
            }
            else if (make == "audi")
            {
                carLot.Add(new Sedan(20000, make));
            }
            else if (make == "honda")
            {
                carLot.Add(new Sedan(20000, make));
            }
            else
            {
                return orderSedan();
            }
            Console.WriteLine("Sedan added!");
            return 1;
        }

        public int orderSportsCar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello! What make of Sports car do you need today? We have Lexus, Audi, and Bently");
            string make = Console.ReadLine().ToLower();
            if (make == "lexus")
            {
                carLot.Add(new SportsCar(18000, make));
            }
            else if (make == "audi")
            {
                carLot.Add(new SportsCar(18000, make));
            }
            else if (make == "bently")
            {
                carLot.Add(new SportsCar(18000, make));
            }
            else
            {
                return orderSportsCar();
            }
            Console.WriteLine("Sports car added!");
            return 1;
        }

        public int orderSUV()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello! What make of SUV do you need today? We have Toyota, GMC, and Ford");
            string make = Console.ReadLine().ToLower();
            if (make == "toyota")
            {
                carLot.Add(new SUV(19000, make));
            }
            else if (make == "GMC")
            {
                carLot.Add(new SUV(19000, make));
            }
            else if (make == "ford")
            {
                carLot.Add(new SUV(19000, make));
            }
            else
            {
                return orderSUV();
            }
            Console.WriteLine("SUV added!");
            return 1;
        }

        public void testForSale()
        {
            Console.WriteLine("Welcome to the testing station, please select the car you'd like to test before putting it on the lot");
            showCarLot();
            int vehicleChoice = Convert.ToInt32(Console.ReadLine());
            carLot[vehicleChoice].hasBeenTested = true;
            Console.WriteLine(carLot[vehicleChoice].make + " has been approved for selling!");
        }

        public void showCarLot()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The number next to the vehicle is the vehicle ID number");
            int i = 0;
            foreach (Vehicle vehicle in carLot)
            {
                Console.WriteLine(i + " " + vehicle.make + " $" + vehicle.price);
                i++;
            }
        }

        public int adjustPrice()
        {
            Console.WriteLine("Would you like to raise or lower price?");
            string priceChoice = Console.ReadLine().ToLower();
            if (priceChoice == "raise")
            {
                raisePrice();
            } else if (priceChoice == "lower")
            {
                lowerPrice();
            }
            else
            {
                return adjustPrice();
            }
            return 1;
        }

        public void raisePrice()
        {
            showCarLot();
            int carChoice = Convert.ToInt32(Console.ReadLine());
            carLot[carChoice].price = carLot[carChoice].price + 1500;
            Console.WriteLine("You've raised the price by $1,500");
            Console.WriteLine("The new price for " + carLot[carChoice].make +" is $" + carLot[carChoice].price);
        }

        public void lowerPrice()
        {
            showCarLot();
            int carChoice = Convert.ToInt32(Console.ReadLine());
            carLot[carChoice].price = carLot[carChoice].price - 1000;
            Console.WriteLine("You've lowered the price by $1,000");
            Console.WriteLine("The new price for " + carLot[carChoice].make + " is $" + carLot[carChoice].price);
        }

        public void carSale()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Let's start a sale shall we?");
            Console.WriteLine("What kind of sale? Large sale or small sale");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please enter large or small");
            string saleType = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (saleType == "large")
            {
                foreach (Vehicle vehicle in carLot)
                {
                    vehicle.price = vehicle.price - 1000;
                }
                Console.WriteLine("You've started the large sale! Every Vehicles' price has gone down by $1,000!");
            } else if (saleType == "small")
            {
                foreach (Vehicle vehicle in carLot)
                {
                    vehicle.price = vehicle.price - 800;
                }
                Console.WriteLine("You've started a smll sale! Every vehicles' price has gone down by $800!");
            }

        }
    }
}
