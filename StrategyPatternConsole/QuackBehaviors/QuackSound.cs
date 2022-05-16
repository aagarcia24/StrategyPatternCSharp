using System;

namespace StrategyPatternConsole
{
    public class QuackSound : IQuackBehavior
    {
        public String Quack() => "Quack!";
    }
}
