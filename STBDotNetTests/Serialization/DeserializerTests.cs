using STBDotNet.Serialization;
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
        public void ElementsTest()
        {
            List<string> pathList = new List<string>
            {
                @"../../../../TestStbFiles/ver1/Sample1.stb",
                // @"../../../../TestStbFiles/ver1/Sample2.stb",
                // @"../../../../TestStbFiles/ver1/Sample3.stb",
                // @"../../../../TestStbFiles/ver1/Sample4.stb",
                // @"../../../../TestStbFiles/ver1/Sample5.stb",
                // @"../../../../TestStbFiles/ver1/Sample6.stb"
            };

            foreach (string path in pathList)
            {
                var item = new Deserializer(path);
                StbElements elements = item.Elements();
                Assert.IsTrue(elements.Version == Version.Stb1);
                Assert.IsTrue(elements.Common.AppName == "Archdata Asin");
                Assert.IsTrue(elements.Common.ReinforcementStrengthList[0].Name == "D6");
                Assert.IsTrue(elements.Common.ReinforcementStrengthList[0].StrengthBar == StrengthBar.S295);
                Assert.IsTrue(elements.Common.ReinforcementStrengthList[31].Name == "S6");
                Assert.IsTrue(elements.Common.ReinforcementStrengthList[31].StrengthBar == StrengthBar.S785);
            }
        }
    }
}