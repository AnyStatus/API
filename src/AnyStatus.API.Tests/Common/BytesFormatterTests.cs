using AnyStatus.API.Common.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnyStatus.API.Tests.Common
{
    [TestClass]
    public class BytesFormatterTests
    {
        [TestMethod]
        public void BytesFormatterBytesTest()
        {
            Assert.AreEqual("532 bytes", BytesFormatter.Format(532));
        }

        [TestMethod]
        public void BytesFormatterKilobytesTest()
        {
            Assert.AreEqual("1.30 KB", BytesFormatter.Format(1340));
        }

        [TestMethod]
        public void BytesFormatterMegabytesTest()
        {
            Assert.AreEqual("2.28 MB", BytesFormatter.Format(2400016));
        }

        [TestMethod]
        public void BytesFormatterGigabytesTest()
        {
            Assert.AreEqual("2.23 GB", BytesFormatter.Format(2400000000));
        }
    }
}
