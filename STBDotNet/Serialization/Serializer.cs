using System;
using System.IO;
using System.Xml.Serialization;
using STBDotNet.Elements;

namespace STBDotNet.Serialization
{
    public class Serializer
    {
        public bool Serialize(StbElements model, string outPath)
        {
            try
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);
                var serializer = new XmlSerializer(typeof(StbElements));
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

        public StbElements Deserialize(string stbPath)
        {
            var fs = new FileStream(stbPath, FileMode.Open);
            var deserializer = new XmlSerializer(typeof(StbElements));
            return (StbElements)deserializer.Deserialize(fs);
        }
    }
}