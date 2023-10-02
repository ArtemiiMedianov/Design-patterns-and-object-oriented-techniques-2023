using BuilderAssignment.Models;

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

        /// <summary>
        /// Sets the broth for the ramen bowl.
        /// </summary>
        /// <param name="broth"></param>
        void SetBroth(string broth);

        /// <summary>
        /// Sets the noodles for the ramen bowl.
        /// </summary>
        /// <param name="noodles"></param>
        void SetNoodles(string noodles);

        /// <summary>
        /// Adds toppings to the ramen bowl.
        /// </summary>
        /// <param name="toppings"></param>
        void AddToppings(string[] toppings);

        /// <summary>
        /// Adds extras to the ramen bowl.
        /// </summary>
        /// <param name="extras"></param>
        void AddExtras(string[] extras);

        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        /// <returns></returns>
        RamenBowl GetRamen();
    }
}
