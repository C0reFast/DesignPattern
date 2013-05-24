using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA(component);
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB(decoratorA);
            decoratorB.Operation();
        }
    }
}
