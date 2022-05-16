using System;

namespace StrategyPatternConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            Console.WriteLine(mallard.PerformQuack());
            Console.WriteLine(mallard.PerformFly());

            Console.WriteLine();

            Duck model = new ModelDuck();
            Console.WriteLine(model.PerformFly());
            model.FlyBehavior = new FlyRocketPowered();
            Console.WriteLine(model.PerformFly());
        }
    }
}
