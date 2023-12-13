using BuilderAssignment.Builders;
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenChef() { }
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.setBroth();
            builder.setNoodles();
            builder.setToppings();
            builder.setExtras();
            return builder.GetRamen(); //TODO#2: Finaly return build bowl of ramen
        }
    }
}
