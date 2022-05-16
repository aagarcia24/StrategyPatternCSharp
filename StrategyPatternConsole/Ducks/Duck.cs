using System;

namespace StrategyPatternConsole
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public String PerformFly() => FlyBehavior.Fly();
        public String PerformQuack() => QuackBehavior.Quack();

        public abstract String Display();

        public String Swim() => "All ducks float, even decoys!";
    }
}
