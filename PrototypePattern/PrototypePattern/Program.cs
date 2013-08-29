using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototypeA p1 = new ConcretePrototypeA(1);
            ConcretePrototypeA c1 = (ConcretePrototypeA)p1.Clone();
            Console.WriteLine("Cloned {0}", c1.Id);

            ConcretePrototypeB p2 = new ConcretePrototypeB(2);
            ConcretePrototypeB c2 = (ConcretePrototypeB)p2.Clone();
            Console.WriteLine("Cloned {0}", c2.Id);
        }
    }
}
