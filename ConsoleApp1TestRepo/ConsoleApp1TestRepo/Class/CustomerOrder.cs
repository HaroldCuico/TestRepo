using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TestRepo.Class
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coffee Coffee { get; set; }


        public CustomerOrder()
        {
            Id++;   
        }

        public void Menu()
        {
            List<string> coffees = new List<string> { "Cappuccino", "Latte", "Mocha", "Americano" };

            Console.Write($"Please enter your name: ");

            this.Name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Please choose your coffee.");
            for (int i = 0; i < coffees.Count; i++)
            {
                Console.WriteLine($"({i + 1}) - {coffees[i]}");
            }

            Console.Write($"Please enter the number:");

            int coffeeType = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine();
            Console.WriteLine($"(1) Hot");
            Console.WriteLine($"(2) Cold");
            Console.Write($"Please choose: ");


            bool coffeeTemp = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;


             //Temporarily Setting the volume to 0.5
            this.Coffee = new Coffee(0.5, coffees[coffeeType], coffeeTemp);
        }

        public void GetOrder()
        {
            Console.WriteLine()
            Console.WriteLine($"{this.Name} order is {Coffee}");
        }
    }
}
