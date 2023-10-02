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
        //TODO#1: Add attributes for each enum in IngredientEnums.cs file
        public BrothType Broth { get; set; }
        public NoodleType Noodle { get; set; }
        public List<ToppingType> Toppings { get; set; }
        public List<ExtraType> Extras { get; set; }

        //TODO#2: Return description of finished bowl of ramen
        public string FinishedBowlOfRamen()
        {
            StringBuilder description = new StringBuilder();

            description.AppendLine($"Bowl of Ramen:");
            description.AppendLine($"Broth: {Broth}");
            description.AppendLine($"Noodle: {Noodle}");
            description.AppendLine("Toppings:");

            foreach (var topping in Toppings)
            {
                description.AppendLine($"- {topping}");
            }

            description.AppendLine("Extras:");

            foreach (var extra in Extras)
            {
                description.AppendLine($"- {extra}");
            }

            return description.ToString();
        }
    }
}
