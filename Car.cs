﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopGUI
{
    public class Car
    {
        // list of properties 
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        // Car constructor with 5 parameters
        public Car(string make, string model, decimal price, string color, int year)
        {
            Make = make;
            Model = model;
            Price = price;
            Color = color;
            Year = year;
        }

        // Car constructor with 0 parameters. Provide default vale
        public Car()
        {
            Make = "Nothing yet";
            Model = "Nothing yet";
            Price = 0;
            Color = "Nothing yet";
            Year = 0;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} ${2} {3} {4}", Make, Model, Price, Color, Year);
            }
        }
    }
}
