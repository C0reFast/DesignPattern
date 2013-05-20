using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = OperationFactory.CreateOperation("+");
            op.NumberA = 10;
            op.NumberB = 20;
            Console.WriteLine(op.GetResult());
        }
    }
}
