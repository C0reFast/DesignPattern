using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component)
            : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            AddedOperation();
        }
        private void AddedOperation()
        {
            Console.WriteLine("ConcreteDecoratorA.AddedOperation()");
        }
    }
}
