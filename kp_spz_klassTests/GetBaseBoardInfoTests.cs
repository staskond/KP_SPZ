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
    public class GetBaseBoardInfoTests
    {
        [Test()]
        public void GetDeviceInfoTest()
        {
            GetBaseBoardInfo temp = new GetBaseBoardInfo();
            temp.GetDeviceInfo();
            Assert.IsTrue(temp.baseBoard.Count != 0);
        }
    }
}