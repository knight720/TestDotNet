using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject1
{
    public class Class1
    {
        [Fact]
        public void MyTestMethod()
        {
            Assert.True(false, "for test");
        }

        [Fact]
        public void MyTestMethod2()
        {
            Assert.True(true);
        }
    }
}
