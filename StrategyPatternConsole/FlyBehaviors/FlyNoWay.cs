using System;

namespace StrategyPatternConsole
{
    public class FlyNoWay : IFlyBehavior
    {
        public String Fly() => "I can't fly";
    }
}
