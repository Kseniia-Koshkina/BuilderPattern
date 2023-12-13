using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    /// - SpicyRamenBuilder
    ///     Recepie: 
    ///     - Broth: SpicyTonkotsu
    ///     - Noodles: Thin
    ///     - Toppings: Gashu Pork & Green Onions
    ///     - Extras: Extra Spice
    internal class SpicyRamenBuilder : IRamenBuilder
    {

        public SpicyRamenBuilder() { }
        private RamenBowl ramenBowl = new RamenBowl("Spicy ramen");

        public RamenBowl GetRamen() => ramenBowl;

        public void setBroth() => ramenBowl.type = BrothType.SpicyTonkotsu;
        public void setExtras() => ramenBowl.noodle = NoodleType.Thin;
        public void setNoodles() => ramenBowl.extra = Extra.ExtraSpice;
        public void setToppings() => ramenBowl.topping = Topping.ChashuPork;
    }
}
