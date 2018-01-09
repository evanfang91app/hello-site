using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HelloSite.XUnit.Test
{
    public class Test1
    {
        [Fact]
        public void Test_Method_Hello_World()
        {
            Assert.True(true);
        }
    }
}
