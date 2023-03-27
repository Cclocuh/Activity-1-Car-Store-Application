﻿using CarShopGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopGUI
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            // We must initialize each list or see the dreaded error: "null reference exception
            // object refernce not set to an instance of an object."
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal checkout()
        {
            decimal totalCost = 0;

            // Calculate the total cost of items in the cart.
            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }
            // clear the shopping cart
            ShoppingList.Clear();

            // return the total
            return totalCost;
        }
    }
}
