﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace CarDealerShip
{
    public class MenuInterface
    {
        public CarDealership dealership = new CarDealership();
        public Customer customer;
        public MenuInterface()
        {
                 customer = new Customer(dealership);
        }
        public int menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to Charles Cars, are you a customer or an employee?");
            Console.WriteLine("You may also exit the program from here, just type 'exit'");
            string answer = Console.ReadLine().ToLower();
            if (answer.Equals("customer"))
            {
                customerMenu();
            } else if (answer.Equals("employee"))
            {
                employeeMenu();
            } else if (answer.Equals("exit"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("It's been fun!");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    Console.Write(". ");
                }
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR!");
                return menu();
            }
            return 1;
        }
        public int customerMenu()
        {            
            bool runCMenu = true;
            while (runCMenu)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome customer! What would you like to do?");
                Console.WriteLine("Enter 1 to look at the lot");
                Console.WriteLine("Enter 2 to test a car");
                Console.WriteLine("Enter 3 to attempt to haggle");
                Console.WriteLine("Enter 4 to buy a car");
                Console.WriteLine("Enter 5 to go back to the main menu");
                int customerChoice = Convert.ToInt32(Console.ReadLine());
                switch (customerChoice)
                {
                    case 1:
                        Console.Clear();
                        dealership.showCarLot();
                        break;
                    case 2:
                        customer.testDrive();
                        break;
                    case 3:
                        Console.Clear();
                        customer.haggle();
                        break;
                    case 4:
                        Console.Clear();
                        customer.buyACar();
                        break;
                    case 5:
                        Console.Clear();
                        return menu();
                        
                }
            }
            return 0;
        }
        public int employeeMenu()
        {
            bool runEMenu = true;
            while (runEMenu)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome valued employee! What would you like to do?");
                Console.WriteLine("Enter 1 to put in an order for cars.");
                Console.WriteLine("Enter 2 to order a specific car.");
                Console.WriteLine("Enter 3 to test a car to see if it can be sold.");
                Console.WriteLine("Enter 4 to raise/lower the price.");
                Console.WriteLine("Enter 5 to start a sale.");
                Console.WriteLine("Enter 6 to return to menu.");
                int employeechoice = Convert.ToInt32(Console.ReadLine());
                switch (employeechoice)
                {
                    case 1:
                        Console.Clear();
                        dealership.orderCars();
                        break;
                    case 2:
                        Console.Clear();
                        dealership.specialOrderCars();
                        break;
                    case 3:
                        Console.Clear();
                        dealership.testForSale();
                        break;
                    case 4:
                        Console.Clear();
                        dealership.adjustPrice();
                        break;
                    case 5:
                        Console.Clear();
                        dealership.carSale();
                        break;
                    case 6:
                        return menu();
                }
            }
            return 0;
        }
    }
}
