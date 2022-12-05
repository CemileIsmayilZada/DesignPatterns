using DesignPattern.AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPattern
{
    public class Adapter:ITarget
    {
        public Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void subtract()
        {
            adaptee.SubtractMessage();
        }

        public void sum()
        {
           adaptee.SumMessage();
        }
    }
}
