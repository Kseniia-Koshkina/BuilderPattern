using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    /// - VeganRamenBuilder
    ///     Recepie: 
    ///     - Broth: Vegan
    ///     - Noodles: Soba
    ///     - Toppings: Bambo Shoots & Seaweed
    ///     - Extras: no extras
    internal class VeganRamenBuilder : IRamenBuilder
    {

        public VeganRamenBuilder() { }
        private RamenBowl ramenBowl = new RamenBowl("Vegan ramen");

        public RamenBowl GetRamen() => ramenBowl;

        public void setBroth() => ramenBowl.type = BrothType.Vegan;
        public void setExtras() => ramenBowl.noodle = NoodleType.Soba;
        public void setNoodles() => ramenBowl.extra = null;
        public void setToppings() => ramenBowl.topping = Topping.BambooShoots;
    }
}
