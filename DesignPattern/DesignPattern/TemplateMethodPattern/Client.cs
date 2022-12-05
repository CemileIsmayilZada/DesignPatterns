using DesignPattern.TemplateMethodPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethodPattern
{
    internal class Client
    {
        public void ClientCall(Phone phone)
        {
            phone.TemplateMethod();
        }
    }
}
