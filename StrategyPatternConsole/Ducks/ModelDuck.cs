using System;

namespace StrategyPatternConsole
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new QuackSound();
        }
        public override String Display() => "I'm a model duck!";
    }
}
