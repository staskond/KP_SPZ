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
    public class VideoControllerStorageInfoTests
    {
        [Test()]
        public void VideoControllerStorageInfoTest()
        {
            VideoControllerStorageInfo test = new VideoControllerStorageInfo("123",
                "proc",
                "adapter",
                "capt",
                "desc");
            Assert.AreEqual("123", test.GetDeviceID());
            Assert.AreEqual("proc", test.GetVodeoProcessor());
            Assert.AreEqual("adapter", test.GetAdapterRAM());
            Assert.AreEqual("capt", test.GetCaption());
            Assert.AreEqual("desc", test.GetDescription());
            //Assert.Fail();
        }
    }
}