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
    public class GetHDDInfoTests
    {
        [Test()]
        public void GetDeviceInfoTest()
        {
            GetHDDInfo temp = new GetHDDInfo();
            temp.GetDeviceInfo();
            Assert.IsTrue(temp.hddInfo.Count != 0);
        }
    }
}