using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class StrategyC : IStrategy
    {

        public void Execute()
        {
            Console.WriteLine("StrategyC");
        }
    }
}
