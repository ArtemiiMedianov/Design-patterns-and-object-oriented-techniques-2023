namespace DecoratorAssignment
{
    public interface Beverage
    {
        string GetDescription();
        double Cost();
    }

    public class HouseBlend : Beverage
    {
        public string GetDescription()
        {
            return "House Blend Coffee";
        }

        public double Cost()
        {
            return 1.80;
        }
    }

    public class DarkRoast : Beverage
    {
        public string GetDescription()
        {
            return "Dark Roast Coffee";
        }

        public double Cost()
        {
            return 2.20;
        }
    }

    public class Espresso : Beverage
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public double Cost()
        {
            return 2.90;
        }
    }

    public class Decaf : Beverage
    {
        public string GetDescription()
        {
            return "Decaf Coffee";
        }

        public double Cost()
        {
            return 2.00;
        }
    }

    public interface CondimentDecorator : Beverage
    {
    }

    public class SteamedMilk : CondimentDecorator
    {
        private Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription() + ", Steamed Milk";
        }

        public double Cost()
        {
            return _beverage.Cost() + 0.30;
        }
    }

    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public double Cost()
        {
            return _beverage.Cost() + 0.60;
        }
    }

    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public double Cost()
        {
            return _beverage.Cost() + 0.45;
        }
    }

    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public double Cost()
        {
            return _beverage.Cost() + 0.30;
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            Console.WriteLine("Description: " + beverage.GetDescription());
            Console.WriteLine("Cost: $" + beverage.Cost());
        }
    }
}
