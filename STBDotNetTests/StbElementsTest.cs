using System.Reflection.Metadata;
using System.Xml.Serialization;
using NUnit.Framework;
using STBDotNet.Elements;

namespace STBDotNetTests
{
    [TestFixture]
    public class StbElementsTest
    {
        [Test]
        public void Stb1SerializeTest()
        {
            // Deserialize Test
            var fs = new System.IO.FileStream(@"../../../../TestStbFiles/ver1/xmlSerializeTest.stb", System.IO.FileMode.Open);
            var deserializer = new XmlSerializer(typeof(StbElements));
            var model = (StbElements)deserializer.Deserialize(fs);

            // Serialize Test
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            const string serializeFileName = "../../../Result/xmlSerializeTest.stb";
            var serializer = new XmlSerializer(typeof(StbElements));
            var sw = new System.IO.StreamWriter(serializeFileName, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, model, namespaces);
            sw.Close();
        }
    }
}