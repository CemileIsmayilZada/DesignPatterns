using DesignPattern.BridgePattern.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BridgePattern
{
    public class Abstraction
    {
        public Bridge bridge;

        public Abstraction(Bridge bridge)
        {
            this.bridge = bridge;
        }

        public void CallingOperation()
        {
            bridge.TakeIt();
        }


    }
}
