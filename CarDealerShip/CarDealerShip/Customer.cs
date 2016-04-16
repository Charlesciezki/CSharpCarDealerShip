using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class Customer
    {
        public CarDealership carDealership;
        public string name;
        public int id;
        public Vehicle vehicle;
        public List<Customer> customerList = new List<Customer>();
        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
            vehicle = null;
        }
        public Customer(CarDealership carDealership)
        {
        this.carDealership = carDealership;
        Customer bob = new Customer("Bob", 0);
        Customer billy = new Customer("Billy", 1);
        Customer charles = new Customer("Charles", 2);
        Customer zach = new Customer("Zach", 3);
        customerList.Add(bob);
            customerList.Add(billy);
            customerList.Add(charles);
            customerList.Add(zach);
        }
        public void haggle()
        {
            carDealership.showCarLot();
            Console.WriteLine("Please choose a car to haggle on by the ID");
            int carChoice = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int haggleChance = random.Next(1, 11);
            if (haggleChance == 1)
            {
                Console.WriteLine("Offer accpeted! -$1000!");
                carDealership.carLot[carChoice].price = carDealership.carLot[carChoice].price - 1000;
            } else if (haggleChance == 2)
            {
                Console.WriteLine("You drive a hard bargain... -$2500!");
                carDealership.carLot[carChoice].price = carDealership.carLot[carChoice].price - 2500;
            }
            else
            {
                Console.WriteLine("Offer refused!");
            }
        }
    }
}