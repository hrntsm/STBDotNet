using NUnit.Framework;
using STBDotNet.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace STBDotNet.Serialization.Tests
{
    [TestFixture()]
    public class DeserializerTests
    {
        [Test()]
        public void DeserializerTest()
        {
            var item = new Deserializer();
            Assert.IsTrue(item != null);
        }

        [Test()]
        public void DeserializerTest1()
        {
            var path = "path";
            var item = new Deserializer(path);
            Assert.IsTrue(item.Path == path);
        }

        [Test()]
        public void BuildTest()
        {
            Assert.Fail();
        }
    }
}