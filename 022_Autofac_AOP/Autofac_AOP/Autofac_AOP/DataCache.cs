using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Autofac_AOP
{
    public class DataCache : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            this.LoadCache();

            invocation.Proceed();
        }

        private void LoadCache()
        {
            Console.WriteLine("Load Cache");
        }
    }
}
