﻿using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    /// <summary>
    /// This is an interface represeting the steps to build the ramen bowl
    /// </summary>
    public interface IRamenBuilder
    {
        // TODO#1: Add methods for following steps
        // - Setting broth
        // - Setting noodles
        // - Adding toppings
        // - Adding Extras
        public void setBroth();
        public void setNoodles();
        public void setToppings();
        public void setExtras();


        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        /// <returns></returns>
        RamenBowl GetRamen();
    }
}
