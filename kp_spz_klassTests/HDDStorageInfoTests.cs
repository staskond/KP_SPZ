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
    public class HDDStorageInfoTests
    {
        [Test()]
        public void HDDStorageInfoTest()
        {
            HDDStorageInfo hdd = new HDDStorageInfo("deviceID",
                "serialNumber",
                "model",
                "interfaceType",
                "manufacturer",
                132);
            Assert.AreEqual("deviceID", hdd.GetDeviceID());
            Assert.AreEqual("serialNumber", hdd.GetSerialNumber());
            Assert.AreEqual("model", hdd.GetModel());
            Assert.AreEqual("interfaceType", hdd.GetInterfaceType());
            Assert.AreEqual("manufacturer", hdd.GetManufacturer());
            Assert.AreEqual(132, hdd.GetSize());
        }
    }
}