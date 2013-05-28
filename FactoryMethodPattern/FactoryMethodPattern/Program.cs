using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory;
            Operation operation;

            factory = new AddFactory();
            operation = factory.CreateOperation();
            operation.NumberA = 50;
            operation.NumberB = 10;
            Console.WriteLine(operation.GetResult());

            factory = new SubFactory();
            operation = factory.CreateOperation();
            operation.NumberA = 50;
            operation.NumberB = 10;
            Console.WriteLine(operation.GetResult());

            factory = new MulFactory();
            operation = factory.CreateOperation();
            operation.NumberA = 50;
            operation.NumberB = 10;
            Console.WriteLine(operation.GetResult());

            factory = new DivFactory();
            operation = factory.CreateOperation();
            operation.NumberA = 50;
            operation.NumberB = 10;
            Console.WriteLine(operation.GetResult());
        }
    }
}
