using System;

namespace StrategyPatternConsole
{
    public class MuteQuack : IQuackBehavior
    {
        public String Quack() => "<< Silence >>";
    }
}
