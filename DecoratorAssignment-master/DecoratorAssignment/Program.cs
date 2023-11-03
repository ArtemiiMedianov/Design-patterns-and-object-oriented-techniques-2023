namespace DecoratorAssignment
{
    public interface Beverage
    {
        double Cost();
    }

    public class HouseBlend : Beverage
    {
        public double Cost()
        {
            return 1.80;
        }
    }
    
    public class DarkRoast : Beverage
    {
        public double Cost()
        {
            return 2.20;
        }
    }
    
    public class Espresso : Beverage
    {
        public double Cost()
        {
            return 2.90;
        }
    }
    
    public class Decaf : Beverage
    {
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
    
            Console.WriteLine("Description: " + beverage.GetType().Name);
            Console.WriteLine("Cost: $" + beverage.Cost());
        }
    }
}
