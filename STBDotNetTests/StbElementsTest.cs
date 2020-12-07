using System.Collections.Generic;
using System.Xml.Serialization;
using NUnit.Framework;
using STBDotNet.Elements;

namespace STBDotNetTests
{
    [TestFixture]
    public class StbElementsTest
    {
        private readonly List<string> _pathList = new List<string>
        {
            "Sample1", "Sample2", "Sample3", "Sample4", "Sample5", "Sample6", "xmlSerializeTest"
        };

        [Test]
        public void Stb1SerializeTest()
        {
            foreach (string path in _pathList)
            {
                var stbPath = $@"../../../../TestStbFiles/ver1/{path}.stb";
                var outPath = $@"../../../Result/{path}.stb";

                // Deserialize Test
                var serializer = new STBDotNet.Serialization.Serializer();
                StbElements model = serializer.Deserialize(stbPath);

                // Serialize Test
                serializer.Serialize(model, outPath);
            }
        }
    }
}