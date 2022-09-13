using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TestRepo
{
    class CoffeeList
    {
        private Coffee[] coffees;
        private int pos;
        public CoffeeList()
        {
            coffees = new Coffee[10];
        }

        public void addCoffee(Coffee coffee)
        {
            coffees[pos++] = coffee;
        }

        public void displayAllCoffee()
        {
            foreach(Coffee coffee in coffees)
            {
                Console.WriteLine(coffee);
            }
        }
    }
}
