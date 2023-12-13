using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    /// - MisoRamenBuilder
    ///     Recepie: 
    ///     - Broth: Miso
    ///     - Noodles: Udon
    ///     - Toppings: Green Onions
    ///     - Extras: Corn
    public class MisoRamenBuilder : IRamenBuilder
    {

        public MisoRamenBuilder() { }
        private RamenBowl ramenBowl = new RamenBowl("Miso ramen");

        public RamenBowl GetRamen() => ramenBowl;

        public void setBroth() => ramenBowl.type = BrothType.Miso;
        public void setExtras() => ramenBowl.noodle = NoodleType.Udon;
        public void setNoodles() => ramenBowl.extra = Extra.Corn;
        public void setToppings() => ramenBowl.topping = Topping.GreenOnions;
    }
}
