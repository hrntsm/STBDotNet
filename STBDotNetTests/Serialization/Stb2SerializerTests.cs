using NUnit.Framework;
using STBDotNet.Enums;

namespace STBDotNet.Serialization.Tests
{
    [TestFixture]
    public class Stb2SerializerTests
    {
        [Test]
        public void Stb2SerializeTest()
        {
            var stbPath = $@"../../../../TestStbFiles/ver2/Sample1.stb";
            var outPath = $@"../../../Result/ver2/Sample1.stb";

            // Deserialize Test
            var model = (v202.ST_BRIDGE)Serializer.Deserialize(stbPath);
            // Serialize Test
            bool result = Serializer.Serialize(model, outPath);

            Assert.IsTrue(result);
        }

        [Test]
        public void Stb2SerializeSetVersionTest()
        {
            var stbPath = $@"../../../../TestStbFiles/ver2/Sample1.stb";
            var outPath = $@"../../../Result/ver2/Sample1.stb";

            // Deserialize Test
            var model = (v201.ST_BRIDGE)Serializer.Deserialize(stbPath, Version.Stb201);
            // Serialize Test
            bool result = Serializer.Serialize(model, outPath, Version.Stb201);

            Assert.IsTrue(result);
        }
    }
}
