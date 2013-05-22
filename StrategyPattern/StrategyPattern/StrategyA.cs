using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class StrategyA : IStrategy
    {

        public void Execute()
        {
            Console.WriteLine("StrategyA");
        }
    }
}
