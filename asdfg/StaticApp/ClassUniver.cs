using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdfg.StaticApp
{
    public class ClassUniver
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string ForWho { get; set; }
        public ClassUniver(string name, string cost, string description, string forWho)
        {
            Name = name;
            Cost = cost;
            Description = description;
            ForWho = forWho;
        }
    }
}
