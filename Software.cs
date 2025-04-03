using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num8
{
    abstract class Software
    {
        string name;
        public string Name { get; set; }
        public Software(string name)
        {
            Name = name;
        }
        public abstract void Print();
        public abstract bool IsUsable();  
    }
}
