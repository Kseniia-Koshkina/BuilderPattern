using BuilderAssignment.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    public class RamenBowl
    {
        public RamenBowl(string name) => this.name = name;
        //TODO#1: Add attributes for each enum in IngredientEnums.cs file
        public  BrothType? type;
        public  NoodleType? noodle;
        public  Topping? topping;
        public  Extra? extra;
        public string name;
        //TODO#2: Return description of finished bowl of ramen
       
        public string FinishedBowlOfRamen() =>
            "-" + name + "\n  -Broth: " + type.ToString() + "\n  -Noodle: " + noodle.ToString() +
            "\n  -Topping: " + topping.ToString()+ "\n  -Extras: " + extra.ToString()+"\n";







    }
}
