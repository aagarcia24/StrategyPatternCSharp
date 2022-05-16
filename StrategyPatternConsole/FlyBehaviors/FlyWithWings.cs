using System;

namespace StrategyPatternConsole
{
    public class FlyWithWings : IFlyBehavior
    {
        public String Fly() => "I'm Flying";
    }
}
