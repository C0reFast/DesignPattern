using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject.Request()");
        }
    }
}
