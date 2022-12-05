using DesignPattern.StrategyPattern.Interfacees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    public  class Context
    {
        public IStrategy _strategy;

        public Context()
        {

        }
        public Context(IStrategy strategy)
        {
            _strategy = strategy;    
        }
        
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        
        public void Operation()
        {
            _strategy.Move();
        }


    }
}
