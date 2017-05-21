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
    public class HardWareInfoTests
    {
        [Test()]
        public void HardWareInfoTest()
        {
            HardWareInfo HardWare = new HardWareInfo("HDDserialNumber",
                "ProcessorName",
                "ProcessorID",
                "VideoControllerId",
                "BaseGoardSerialNumber");
            Assert.AreEqual("HDDserialNumber", HardWare.HDDserialNumber);
            Assert.AreEqual("ProcessorName", HardWare.ProcessorName);
            Assert.AreEqual("ProcessorID", HardWare.ProcessorID);
            Assert.AreEqual("VideoControllerId", HardWare.VideoControllerId);
            Assert.AreEqual("BaseGoardSerialNumber", HardWare.BaseGoardSerialNumber);
        }

        [Test()]
        public void EqualsTest()
        {
            HardWareInfo HardWare1 = new HardWareInfo("HDDserialNumber",
                "ProcessorName",
                "ProcessorID",
                "VideoControllerId",
                "BaseGoardSerialNumber",
                Convert.ToDateTime("20.05.2018"));

            HardWareInfo HardWare2 = new HardWareInfo("HDDserialNumber",
                "ProcessorName",
                "ProcessorID",
                "VideoControllerId",
                "BaseGoardSerialNumber",
                Convert.ToDateTime("15.05.2018"));

            Assert.IsTrue(HardWare1.Equals(HardWare2));
        }
    }
}