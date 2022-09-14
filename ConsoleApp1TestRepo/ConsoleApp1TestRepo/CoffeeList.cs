using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TestRepo
{
    public class CoffeeList
    {
        private Coffee[] coffees;
        private int pos;
        public CoffeeList()
        {
            coffees = new Coffee[10];
        }

        public void AddCoffee(Coffee coffee)
        {
            coffees[pos++] = coffee;
        }

        public void DisplayAllCoffee()
        {
            foreach(Coffee coffee in coffees)
            {
                Console.WriteLine(coffee);
            }
        }

        public Coffee GetCoffee(int index)
        {
            return coffees[index];
        }

        public bool DeleteCoffee(int index)
        {
            if (coffees[index] != null)
            {
                coffees[index--] = null;
                return true;
            }
            return false;
        }
    }
}
