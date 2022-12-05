using DesignPattern.TemplateMethodPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethodPattern.Inherits
{
    internal class Nokia : Phone
    {
        public override void CallMember()
        {
            Console.WriteLine("Nokia can call member");
        }

        public override void TakePhoto()
        {
            Console.WriteLine("Nokia can take photo");
        }

        public override void PlayGame()
        {
            Console.WriteLine("Nokia can play game");
        }
    }
}

