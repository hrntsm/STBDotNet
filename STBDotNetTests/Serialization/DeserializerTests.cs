using NUnit.Framework;
using System.Collections.Generic;
using STBDotNet.Elements;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbExtension;
using STBDotNet.Elements.StbFromIfc;
using STBDotNet.Elements.StbModel;

namespace STBDotNet.Serialization.Tests
{
    [TestFixture]
    public class DeserializerTests
    {
        private readonly List<string> _pathList = new List<string>
        {
            @"../../../../TestStbFiles/ver1/Sample1.stb",
            // @"../../../../TestStbFiles/ver1/Sample2.stb",
            // @"../../../../TestStbFiles/ver1/Sample3.stb",
            // @"../../../../TestStbFiles/ver1/Sample4.stb",
            // @"../../../../TestStbFiles/ver1/Sample5.stb",
            // @"../../../../TestStbFiles/ver1/Sample6.stb"
        };

        [Test]
        public void ElementsTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                item.Elements();
            }
        }

        [Test]
        public void CommonTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                Common common = item.Common();
                // stbcommon
                Assert.IsTrue(common.Guid == "64F82436-F0EE-43CD-9ABF-4F40ACF9728E");
                Assert.IsTrue(common.ProjectName == "GS");
                Assert.IsTrue(common.AppName == "Archdata Asin");
                Assert.IsTrue(common.StrengthConcrete == StrengthConcrete.Fc21);
                // StbReinforcement_Strength_List
                Assert.IsTrue(common.ReinforcementStrengthList[0].Name == "D6");
                Assert.IsTrue(common.ReinforcementStrengthList[0].StrengthBar == StrengthBar.S295);
                Assert.IsTrue(common.ReinforcementStrengthList[31].Name == "S6");
                Assert.IsTrue(common.ReinforcementStrengthList[31].StrengthBar == StrengthBar.S785);
            }
        }

        [Test]
        public void ModelTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                item.Model();
            }
        }

        [Test]
        public void FromIfcTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                item.FromIfc();
            }
        }

        [Test]
        public void ExtensionsTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                item.Extensions();
            }
        }
    }
}