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
    public class GetVideoControllerInfoTests
    {
        [Test()]
        public void GetDeviceInfoTest()
        {
            GetVideoControllerInfo temp = new GetVideoControllerInfo();
            temp.GetDeviceInfo();
            Assert.IsTrue(temp.videoControllers.Count != 0);
        }
    }
}