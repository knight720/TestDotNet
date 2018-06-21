using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy;

namespace Autofac_AOP
{
    [Intercept(typeof(DataCache))]
    public class ClassB
    {

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        
        public virtual void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
    }
}
