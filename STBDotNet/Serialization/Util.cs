using System;
using System.Xml.Linq;
using Version = STBDotNet.Elements.Version;

namespace STBDotNet.Serialization
{
    public class Util
    {
        public static string GetXmlNameSpace(XElement root)
        {
            string xmlns = root.Attribute("xmlns") != null
                ? "{" + (string)root.Attribute("xmlns") + "}"
                : string.Empty;

            return xmlns;
        }

        public static Version GetStbVersion(XElement root)
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