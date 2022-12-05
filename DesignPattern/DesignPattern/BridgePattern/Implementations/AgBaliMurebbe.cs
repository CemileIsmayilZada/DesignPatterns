using DesignPattern.BridgePattern.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BridgePattern.Implementations
{
    public class AgBaliMurebbe : Bridge
    {
        public void TakeIt()
        {
            Console.WriteLine("Ag bali goturdum");
        }
    }
}
