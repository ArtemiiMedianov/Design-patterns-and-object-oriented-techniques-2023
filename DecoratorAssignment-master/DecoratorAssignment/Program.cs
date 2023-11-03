namespace DecoratorAssignment
{
    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there
            // Beverage interface
    public interface Beverage
    {
        double Cost();
    }

    // Concrete Beverage classes
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
    
    // CondimentDecorator interface
    public interface CondimentDecorator : Beverage
    {
    }
    
    // Concrete CondimentDecorator classes
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
