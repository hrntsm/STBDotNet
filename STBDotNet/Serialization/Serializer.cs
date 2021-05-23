using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using STBDotNet.Utils;
using STBDotNet.v140;
using STBDotNet.v202;
using Version = STBDotNet.Enums.Version;

namespace STBDotNet.Serialization
{
    public class Serializer
    {
        public static bool Serialize(object stBridge, string outPath)
        {
            switch (stBridge)
            {
                case StBridge140 _:
                    var namespaces1 = new XmlSerializerNamespaces();
                    namespaces1.Add(string.Empty, string.Empty);
                    var serializer1 = new XmlSerializer(typeof(StBridge140));
                    using (var sw = new StreamWriter(outPath, false, new System.Text.UTF8Encoding(false)))
                    {
                        serializer1.Serialize(sw, stBridge, namespaces1);
                    }
                    return true;
                case StBridge202 _:
                    var namespaces2 = new XmlSerializerNamespaces();
                    namespaces2.Add(string.Empty, "https://www.building-smart.or.jp/dl");
                    var serializer2 = new XmlSerializer(typeof(StBridge202));
                    using (var sw = new StreamWriter(outPath, false, new System.Text.UTF8Encoding(false)))
                    {
                        serializer2.Serialize(sw, stBridge, namespaces2);
                    }
                    return true;
                default:
                    throw new ArgumentException("Unsupported type");
            }
        }

        public static object Deserialize(string stbPath)
        {
            XDocument xDocument = XDocument.Load(stbPath);
            Version version = Util.GetStbVersion(xDocument.Root);

            var fs = new FileStream(stbPath, FileMode.Open);
            switch (version)
            {
                
                case Version.Stb140:
                    var deserializer1 = new XmlSerializer(typeof(StBridge140));
                    return (StBridge140)deserializer1.Deserialize(fs);
                case Version.Stb202:
                    var deserializer2 = new XmlSerializer(typeof(StBridge202));
                    return deserializer2.Deserialize(fs);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}