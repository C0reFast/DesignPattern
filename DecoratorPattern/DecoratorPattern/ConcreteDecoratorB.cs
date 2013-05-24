using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component)
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
            Console.WriteLine("ConcreteDecoratorB.AddedOperation()");
        }
    }
}
