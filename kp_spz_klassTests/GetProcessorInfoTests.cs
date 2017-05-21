using NUnit.Framework;
using kp_spz_klass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp_spz_klass.Tests
{
    [TestFixture()]
    public class GetProcessorInfoTests
    {
        [Test()]
        public void GetDeviceInfoTest()
        {
            GetProcessorInfo temp = new GetProcessorInfo();
            temp.GetDeviceInfo();
            Assert.IsTrue(temp.processorInfo.Count != 0);
        }
    }
}