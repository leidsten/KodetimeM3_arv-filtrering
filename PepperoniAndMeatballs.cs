using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodetimeM3_0109
{
    internal class PepperoniAndMeatballs : Pizza
    {
        public PepperoniAndMeatballs( string cheese, string sauce) : base( new string[] {"Meatballs", "Pepperoni"}, cheese, sauce)
        {
            this.Crust = "Soft and wet";
        }
    }
}
