using System;
using System.Xml.Linq;
using STBDotNet.Enums;

namespace STBDotNet.Utils
{
    public static class Util
    {
        public static string GetXmlNameSpace(XElement root)
        {
            string xmlns = root.Attribute("xmlns") != null
                ? "{" + (string)root.Attribute("xmlns") + "}"
                : string.Empty;

            return xmlns;
        }

        public static string GetXmlNameSpace(string stbPath)
        {
            XDocument stbDocument = XDocument.Load(stbPath);
            XElement root = stbDocument.Root;

            return GetXmlNameSpace(root);
        }

        public static Enums.Version GetStbVersion(XElement root)
        {
            var tmp = (string)root.Attribute("version");
            string[] versionString = tmp.Split('.');
            switch (versionString[0])
            {
                case "1":
                    return Enums.Version.Stb140;
                case "2":
                    switch (versionString[2])
                    {
                        case "0":
                            return Enums.Version.Stb200;
                        case "1":
                            return Enums.Version.Stb201;
                        case "2":
                            return Enums.Version.Stb202;
                        default:
                            throw new ArgumentException("Unsupported ST_Bridge version.");
                    }
                default:
                    throw new ArgumentException("Unsupported ST_Bridge version.");
            }
        }
        public static Enums.Version GetStbVersion(string stbPath)
        {
            XDocument stbDocument = XDocument.Load(stbPath);
            XElement root = stbDocument.Root;

            return GetStbVersion(root);
        }

        public static StrengthConcrete GetStrengthConcrete(string concreteName)
        {
            switch (concreteName)
            {
                case "FC18": return StrengthConcrete.Fc18;
                case "FC21": return StrengthConcrete.Fc21;
                case "FC24": return StrengthConcrete.Fc24;
                case "FC27": return StrengthConcrete.Fc27;
                case "FC30": return StrengthConcrete.Fc30;
                case "FC33": return StrengthConcrete.Fc33;
                case "FC36": return StrengthConcrete.Fc36;
                case "FC40": return StrengthConcrete.Fc40;
                case "FC42": return StrengthConcrete.Fc42;
                case "FC45": return StrengthConcrete.Fc45;
                case "FC50": return StrengthConcrete.Fc50;
                case "FC55": return StrengthConcrete.Fc55;
                case "FC60": return StrengthConcrete.Fc60;
                case "FC70": return StrengthConcrete.Fc70;
                case "FC80": return StrengthConcrete.Fc80;
                case "FC90": return StrengthConcrete.Fc90;
                case "FC100": return StrengthConcrete.Fc100;
                default: return StrengthConcrete.Other;
            }
        }

        public static StrengthBar GetStrengthBar(string barName)
        {
            switch (barName)
            {
                case "SR235":
                    return StrengthBar.S235;
                case "SD295":
                case "SD295A":
                    return StrengthBar.S295;
                case "SD345":
                    return StrengthBar.S345;
                case "SHD685":
                    return StrengthBar.S685;
                case "KSS785":
                case "UB785":
                case "KW785":
                case "MK785":
                    return StrengthBar.S785;
                case "SBPD1275":
                case "SBPDN1275":
                    return StrengthBar.S1275;
                default:
                    return StrengthBar.Other;
            }
        }
    }
}