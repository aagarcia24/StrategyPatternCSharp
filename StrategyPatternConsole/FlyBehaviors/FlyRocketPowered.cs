using System;

namespace StrategyPatternConsole
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public String Fly() => "I'm flying with a rocket!";
    }
}
