using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    public class Proxy : ISubject
    {
        RealSubject realSubject;

        public void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            PreRequest();
            realSubject.Request();
            PostRequest();
        }

        public void PreRequest()
        {
            Console.WriteLine("Proxy.PreRequest()");
        }

        public void PostRequest()
        {
            Console.WriteLine("Proxy.PostRequest()");
        }
    }
}
