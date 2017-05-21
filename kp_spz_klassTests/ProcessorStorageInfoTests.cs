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
    public class ProcessorStorageInfoTests
    {
        [Test()]
        public void ProcessorStorageInfoTest()
        {
            ProcessorStorageInfo first = new ProcessorStorageInfo("cpu", 19, "cpu 1");
            Assert.AreEqual("cpu", first.GetProcessorName());
            Assert.AreEqual("cpu 1", first.GetProcessorID());
            Assert.AreEqual(19, first.GetNumbersOfCorec());
        }
    }
}