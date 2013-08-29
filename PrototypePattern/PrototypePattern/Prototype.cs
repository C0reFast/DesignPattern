using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    public abstract class Prototype
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Prototype(int id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();
    }
}
