using NUnit.Framework;
using System.Collections.Generic;
using STBDotNet.Elements;
using Version = STBDotNet.Elements.Version;

namespace STBDotNet.Serialization.Tests
{
    [TestFixture]
    public class DeserializerTests
    {
        [Test]
        public void DeserializerTest()
        {
            var item = new Deserializer();
            Assert.IsTrue(item != null);
        }

        [Test]
        public void DeserializerTest1()
        {
            const string path = "path";
            var item = new Deserializer(path);
            Assert.IsTrue(item.Path == path);
        }

        [Test]
        public void BuildTest()
        {
            List<string> pathList = new List<string>
            {
                @"../../../TestStbFiles/ver1/Sample1.stb",
                @"../../../TestStbFiles/ver1/Sample2.stb",
                @"../../../TestStbFiles/ver1/Sample3.stb",
                @"../../../TestStbFiles/ver1/Sample4.stb",
                @"../../../TestStbFiles/ver1/Sample5.stb",
                @"../../../TestStbFiles/ver1/Sample6.stb"
            };

            foreach (string path in pathList)
            {
                var item = new Deserializer(path);
                StbElements elements = item.Build();
                Assert.IsTrue(elements.Version == Version.Stb1);
            }
        }
    }
}