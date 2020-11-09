using System;
using System.Xml.Linq;
using STBDotNet.Elements;
using Version = STBDotNet.Elements.Version;

namespace STBDotNet.Serialization
{
    public class Deserializer
    {
        public string Path { get; }
        
        public Deserializer()
        {
        }

        public Deserializer(string path)
        {
            Path = path;
        }

        public StbElements Build()
        {
            var stbElements = new StbElements();
            try
            {
                XDocument xDocument = XDocument.Load(Path);
                XElement root = xDocument.Root;
                string xmlns;

                if (root != null)
                {
                    xmlns = root.Attribute("xmlns") != null
                        ? "{" + (string) root.Attribute("xmlns") + "}"
                        : string.Empty;
                    stbElements.Version = GetStbVersion(root);
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return stbElements;
        }

        private static Version GetStbVersion(XElement root)
        {
            var tmp = (string)root.Attribute("version");
            switch (tmp.Split('.')[0])
            {
                case "1":
                    return Version.Stb1;
                case "2":
                    return Version.Stb2;
                default:
                    throw new ArgumentException("The STB version is not set");
            }
        }
    }
}