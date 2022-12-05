using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CompositePattern.interfaceees
{
    public abstract class Member
    {
        public abstract string Name { get; set; }
        
        public  abstract void AddMember(Member member);
        public abstract void RemoveMember(Member member);
        public Member(string name)
        {
            Name = name;
        }

        public abstract void ExecuteOrder();
    }
}
