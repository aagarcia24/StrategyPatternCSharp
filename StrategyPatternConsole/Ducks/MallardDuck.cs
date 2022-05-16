using System;

namespace StrategyPatternConsole
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new QuackSound();
            FlyBehavior = new FlyWithWings();
        }
        public override String Display() => "I'm a real Mallard Duck";
    }
}
