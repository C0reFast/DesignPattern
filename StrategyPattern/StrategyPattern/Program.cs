using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new StrategyA());
            context.Execute();

            context = new Context(new StrategyB());
            context.Execute();

            context = new Context(new StrategyC());
            context.Execute();

        }
    }
}
