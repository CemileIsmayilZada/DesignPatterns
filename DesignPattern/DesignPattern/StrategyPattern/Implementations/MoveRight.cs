using DesignPattern.StrategyPattern.Interfacees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern.Implementations
{
    internal class MoveRight :IStrategy
    {
        public void Move()
        {
            Console.WriteLine("Right");
        }
    }
}
