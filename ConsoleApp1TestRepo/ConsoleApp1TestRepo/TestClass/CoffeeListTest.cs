using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TestRepo.TestClass
{
    [TestClass]
    public class CoffeeListTest
    {
        public void ShouldAddCoffee() {
            var coffeeList = new CoffeeList();

            Coffee coffee = new Coffee(0.2, "Vanilla Iced Coffee", false);

            coffeeList.addCoffee(coffee);
            Assert.AreEqual(coffeeList.GetCoffee(0), coffee);
        }
    }
}
