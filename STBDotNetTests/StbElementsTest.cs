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
                // Deserialize Test
                var fs = new System.IO.FileStream($@"../../../../TestStbFiles/ver1/{path}.stb", System.IO.FileMode.Open);
                var deserializer = new XmlSerializer(typeof(StbElements));
                var model = (StbElements)deserializer.Deserialize(fs);

                // Serialize Test
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);
                var serializeFileName = $@"../../../Result/{path}.stb";
                var serializer = new XmlSerializer(typeof(StbElements));
                var sw = new System.IO.StreamWriter(serializeFileName, false, new System.Text.UTF8Encoding(false));
                serializer.Serialize(sw, model, namespaces);
                sw.Close();
            }
        }
    }
}