using STBDotNet.Utils;
using NUnit.Framework;
using System.Xml.Linq;
using STBDotNet.Enums;

namespace STBDotNet.Utils.Tests
{
    [TestFixture]
    public class UtilTests
    {
        private const string Stb1Path = @"../../../../TestStbFiles/ver1/Sample1.stb";
        private readonly XDocument _stb1 = XDocument.Load(Stb1Path);
        private const string Stb2Path = @"../../../../TestStbFiles/ver2/Sample1.stb";
        private readonly XDocument _stb2 = XDocument.Load(Stb2Path);

        [Test]
        public void GetXmlNameSpaceTest()
        {
            string ns1 = Util.GetXmlNameSpace(_stb1.Root);
            Assert.AreEqual("", ns1);

            string ns2 = Util.GetXmlNameSpace(_stb2.Root);
            Assert.AreEqual(@"{https://www.building-smart.or.jp/dl}", ns2);
        }

        [Test]
        public void GetXmlNameSpaceTest1()
        {
            string ns1 = Util.GetXmlNameSpace(Stb1Path);
            Assert.AreEqual("", ns1);

            string ns2 = Util.GetXmlNameSpace(Stb2Path);
            Assert.AreEqual(@"{https://www.building-smart.or.jp/dl}", ns2);
        }

        [Test]
        public void GetStbVersionTest()
        {
            Version v1 = Util.GetStbVersion(_stb1.Root);
            Assert.AreEqual(Version.Stb140, v1);

            Version v2 = Util.GetStbVersion(_stb2.Root);
            Assert.AreEqual(Version.Stb201, v2);
        }

        [Test]
        public void GetStbVersionTest1()
        {
            Version v1 = Util.GetStbVersion(Stb1Path);
            Assert.AreEqual(Version.Stb140, v1);

            Version v2 = Util.GetStbVersion(Stb2Path);
            Assert.AreEqual(Version.Stb201, v2);
        }
    }
}