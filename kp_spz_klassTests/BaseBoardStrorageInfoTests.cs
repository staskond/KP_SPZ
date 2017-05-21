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
    public class BaseBoardStrorageInfoTests
    {
        [Test()]
        public void BaseBoardStrorageInfoTest()
        {
            BaseBoardStrorageInfo BaseBoard = new BaseBoardStrorageInfo("caption",
                "product",
                "serialNumber");
            Assert.AreEqual("caption", BaseBoard.GetCaption());
            Assert.AreEqual("product", BaseBoard.GetProduct());
            Assert.AreEqual("serialNumber", BaseBoard.GetSerialNumber());
        }
    }
}