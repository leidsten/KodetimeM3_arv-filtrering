using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodetimeM3_0109
{
    internal class Pizza
    {
        public string Crust { get; set; }
        public string[] Toppings { get; set; }
        public string Cheese { get; set; }
        public string Sauce { get; set; }

       

        public Pizza(string crust, string[] toppings, string cheese, string sauce)
        {
            Crust = crust;
            Toppings = toppings;
            Cheese = cheese;
            Sauce = sauce;
        }

        public Pizza(string[] toppings, string cheese, string sauce)
        {
            Toppings = toppings;
            Cheese = cheese;
            Sauce = sauce;
        }

    }
}
