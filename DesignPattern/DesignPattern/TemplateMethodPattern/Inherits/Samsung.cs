using DesignPattern.TemplateMethodPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethodPattern.Inherits
{
    internal class Samsung : Phone
    {
        public override void CallMember()
        {
            Console.WriteLine("Samsung can call member");
        }

        public override void TakePhoto()
        {
            Console.WriteLine("Samsung can take photo");
        }

        public override void AccessInternet()
        {
            Console.WriteLine("Samsung can access  internet");
        }
    }

}
