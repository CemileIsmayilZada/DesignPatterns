using DesignPattern.CompositePattern.interfaceees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CompositePattern.Implemeantatioss
{
    internal class MiddleMember : Member
    {
        public override string Name { get ; set ; }

        public MiddleMember(string name):base(name)
        {
 Name = name;
        }
        public override void AddMember(Member member)
        {
            throw new NotImplementedException();

        }

        public override void RemoveMember(Member member)
        {
           throw new NotImplementedException();
        }
        public override void ExecuteOrder()
        {
            Console.WriteLine("Middle - " + Name);
        }
    }
}
