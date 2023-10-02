using BuilderAssignment.Builders;
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.BuildBase();
            builder.AddToppings();
            builder.AddSeasonings();
            builder.AddGarnish();
            //TODO#2: Finaly return build bowl of ramen
            return builder.GetRamenBowl();
        }
    }
}
