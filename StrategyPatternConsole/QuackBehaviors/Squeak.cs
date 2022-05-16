using System;

namespace StrategyPatternConsole
{
    public class Squeak : IQuackBehavior
    {
        public String Quack() => "Squeak!";
    }
}
