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
        public void SerializeTest()
        {
            var fs = new System.IO.FileStream(@"../../../../TestStbFiles/ver1/xmlSerializeTest.stb", System.IO.FileMode.Open);
            var deserializer = new System.Xml.Serialization.XmlSerializer(typeof(StbElements));
            var model = (StbElements)deserializer.Deserialize(fs);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            const string serializeFileName = "../../../Result/xmlSerializeTest.stb";
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(StbElements));
            var sw = new System.IO.StreamWriter(serializeFileName, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, model, namespaces);
            sw.Close();

            var aaa = 1;
        }
    }
}