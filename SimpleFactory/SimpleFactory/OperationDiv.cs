using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB - 0 < 0.000000001)
                throw new DivideByZeroException();
            return NumberA / NumberB;
        }
    }
}
