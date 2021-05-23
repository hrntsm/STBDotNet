using System;
using System.IO;
using System.Xml.Serialization;
using STBDotNet.v140;

namespace STBDotNet.Serialization
{
    public class Serializer
    {
        public bool Serialize(StbBridge140 model, string outPath)
        {
            try
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);
                var serializer = new XmlSerializer(typeof(StbBridge140));
                using (var sw = new StreamWriter(outPath, false, new System.Text.UTF8Encoding(false)))
                {
                    serializer.Serialize(sw, model, namespaces);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public StbBridge140 Deserialize(string stbPath)
        {
            var fs = new FileStream(stbPath, FileMode.Open);
            var deserializer = new XmlSerializer(typeof(StbBridge140));
            return (StbBridge140)deserializer.Deserialize(fs);
        }
    }
}