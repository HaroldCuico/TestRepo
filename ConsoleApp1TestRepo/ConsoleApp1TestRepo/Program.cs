﻿using System;
using ConsoleApp1TestRepo.Class;

namespace ConsoleApp1TestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There People Good day Good Night!");
            Console.WriteLine("Coffee Feature");
            CoffeeList coffee = new CoffeeList();

            coffee.AddCoffee(new Coffee(0.5, "Strong Coffee", true));

            coffee.DisplayAllCoffee();


           CustomerOrder customer = new CustomerOrder();
            customer.Menu();
            customer.GetOrder();
        }
    }
}
