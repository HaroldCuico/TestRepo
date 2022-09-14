using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TestRepo.Class
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CoffeeList ListOfCoffee { get; set; }

        public void AddCoffee(Coffee c)
        {
            ListOfCoffee.addCoffee(c);  
        }

        public void GetCoffeeList()
        {
            ListOfCoffee.displayAllCoffee();
        }
    }
}
