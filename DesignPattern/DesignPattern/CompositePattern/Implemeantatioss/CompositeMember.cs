using DesignPattern.CompositePattern.interfaceees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CompositePattern.Implemeantatioss
{
    internal class CompositeMember : Member
    {

        public override string Name { get; set; }
        public CompositeMember(string name) : base(name)
        {
            Name = name;
        }
      



        public override void AddMember(Member member)
        {
            Content.BaseEntity.members.Add(member);
            
        }

        public override void RemoveMember(Member member)
        {
            Content.BaseEntity.members.Remove(member);
        }


        public override void ExecuteOrder()
        {
            foreach (var person in Content.BaseEntity.members)
            {
                Console.WriteLine("person - " + person);
            }
        }
    }
}
