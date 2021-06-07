using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using STBDotNet.Utils;
using Version = STBDotNet.Enums.Version;

namespace STBDotNet.Serialization
{
    public static class Serializer
    {
        public static bool Serialize(object stBridge, string outPath)
        {
            var namespaces = new XmlSerializerNamespaces();
            var serializer = new XmlSerializer(typeof(v140.ST_BRIDGE));
            switch (stBridge)
            {
                case v140.ST_BRIDGE _:
                    namespaces.Add(string.Empty, string.Empty);
                    break;
                case v200.ST_BRIDGE _:
                    namespaces.Add(string.Empty, "https://www.building-smart.or.jp/dl");
                    serializer = new XmlSerializer(typeof(v200.ST_BRIDGE));
                    break;
                case v201.ST_BRIDGE _:
                    namespaces.Add(string.Empty, "https://www.building-smart.or.jp/dl");
                    serializer = new XmlSerializer(typeof(v201.ST_BRIDGE));
                    break;
                case v202.ST_BRIDGE _:
                    namespaces.Add(string.Empty, "https://www.building-smart.or.jp/dl");
                    serializer = new XmlSerializer(typeof(v202.ST_BRIDGE));
                    break;
                default:
                    throw new ArgumentException("Unsupported type");
            }
            using (var sw = new StreamWriter(outPath, false, new System.Text.UTF8Encoding(false)))
            {
                serializer.Serialize(sw, stBridge, namespaces);
            }
            return true;
        }

        public static bool Serialize(object stBridge, string outPath, Version stbVersion)
        {
            var namespaces = new XmlSerializerNamespaces();
            var serializer = new XmlSerializer(typeof(v140.ST_BRIDGE));
            try
            {
                switch (stbVersion)
                {
                    case Version.Stb140:
                        namespaces.Add(string.Empty, string.Empty);
                        break;
                    case Version.Stb200:
                        serializer = new XmlSerializer(typeof(v200.ST_BRIDGE));
                        break;
                    case Version.Stb201:
                        namespaces.Add(string.Empty, "https://www.building-smart.or.jp/dl");
                        serializer = new XmlSerializer(typeof(v201.ST_BRIDGE));
                        break;
                    case Version.Stb202:
                        namespaces.Add(string.Empty, "https://www.building-smart.or.jp/dl");
                        serializer = new XmlSerializer(typeof(v202.ST_BRIDGE));
                        break;
                    default:
                        throw new ArgumentException("Unsupported type");
                }
                using (var sw = new StreamWriter(outPath, false, new System.Text.UTF8Encoding(false)))
                {
                    serializer.Serialize(sw, stBridge, namespaces);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static object Deserialize(string stbPath, Version stbVersion)
        {
            var fs = new FileStream(stbPath, FileMode.Open);
            switch (stbVersion)
            {
                case Version.Stb140:
                    var deserializer1 = new XmlSerializer(typeof(v140.ST_BRIDGE));
                    return (v140.ST_BRIDGE)deserializer1.Deserialize(fs);
                case Version.Stb200:
                    var deserializer200 = new XmlSerializer(typeof(v200.ST_BRIDGE));
                    return (v200.ST_BRIDGE)deserializer200.Deserialize(fs);
                case Version.Stb201:
                    var deserializer201 = new XmlSerializer(typeof(v201.ST_BRIDGE));
                    return (v201.ST_BRIDGE)deserializer201.Deserialize(fs);
                case Version.Stb202:
                    var deserializer202 = new XmlSerializer(typeof(v202.ST_BRIDGE));
                    return (v202.ST_BRIDGE)deserializer202.Deserialize(fs);
                default:
                    throw new ArgumentOutOfRangeException();
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
                    var deserializer1 = new XmlSerializer(typeof(v140.ST_BRIDGE));
                    return (v140.ST_BRIDGE)deserializer1.Deserialize(fs);
                case Version.Stb200:
                case Version.Stb201:
                case Version.Stb202:
                    var deserializer202 = new XmlSerializer(typeof(v202.ST_BRIDGE));
                    return (v202.ST_BRIDGE)deserializer202.Deserialize(fs);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}