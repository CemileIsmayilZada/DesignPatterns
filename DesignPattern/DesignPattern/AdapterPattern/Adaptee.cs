using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPattern
{
    public class Adaptee
    {
        public void SumMessage()
        {
            Console.WriteLine("toplandi");
        }
        public void SubtractMessage()
        {
            Console.WriteLine("cixildi");
        }
    }
}
