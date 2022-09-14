using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TestRepo.Class
{
    public class CustomerOrder
    {
        int Id { get; set; }
        string Name { get; set; }
        CoffeeList ListOfCoffee { get; set; }

        public void GetCoffeeList()
        {
            ListOfCoffee.displayAllCoffee();
        }
    }
}
