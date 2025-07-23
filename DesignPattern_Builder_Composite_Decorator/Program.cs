using DesignPattern_Builder_Composite_Decorator.Builder;
using DesignPattern_Builder_Composite_Decorator.Core;
using DesignPattern_Builder_Composite_Decorator.Decorators;
using DesignPattern_Builder_Composite_Decorator.Interfaces;

namespace DesignPattern_Builder_Composite_Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Build two basic routes
            var builder = new RouteBuilder();
            var route1 = builder.From("Toronto").To("Montreal").WithTransport("Truck").WithCost(100).Build();
            var route2 = builder.From("Montreal").To("Halifax").WithTransport("Train").WithCost(120).Build();

            // Decorate one route with express and insurance
            IRoute decoratedRoute1 = new InsuredRoute(new ExpressRoute(route1));

            // Keep route2 simple
            IRoute decoratedRoute2 = route2;

            // Compose them
            var composite = new CompositeRoute();
            composite.AddRoute(decoratedRoute1);
            composite.AddRoute(decoratedRoute2);

            // Output
            Console.WriteLine("=== Composite Route Description ===");
            Console.WriteLine(composite.Describe());

            Console.WriteLine($"\nTotal Cost: {composite.CalculateCost()}");
        }
    }
}
