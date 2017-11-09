using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_nameof
{
    class ChildClass : ParentClass
    {
        public string School { get; private set; }

        public ChildClass(string name, string school) : base(name)
        {
            this.School = school;
        }
    }
}
