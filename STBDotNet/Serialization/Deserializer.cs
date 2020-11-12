using System;
using System.Xml.Linq;
using STBDotNet.Elements;

namespace STBDotNet.Serialization
{
    public class Deserializer
    {
        public string Path { get; set; }
        
        public Deserializer()
        {
        }

        public Deserializer(string path)
        {
            Path = path;
        }

        public StbElements Elements()
        {
            var stbElements = new StbElements();
            try
            {
                XDocument xDocument = XDocument.Load(Path);
                XElement root = xDocument.Root;

                if (root != null)
                {
                    string xmlns = Util.GetXmlNameSpace(root);
                    stbElements.Version = Util.GetStbVersion(root);
                    stbElements.Common.Deserialize(xDocument, stbElements.Version, xmlns);
                    // stbElements.Model.Deserialize(xDocument, stbElements.Version, xmlns);
                    // stbElements.FromIfc.Deserialize(xDocument, stbElements.Version, xmlns);
                    // stbElements.Extension.Deserialize(xDocument, stbElements.Version, xmlns);
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return stbElements;
        }
    }
}