using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactBook
{
    public abstract class Person
    {
        string name;
        public virtual string setName(string personName)
        {
            name = personName;
            return name;
        }
        
    }
}
