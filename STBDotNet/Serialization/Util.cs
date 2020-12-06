using System;
using System.Collections.Generic;
using System.Xml.Linq;
using STBDotNet.Elements;
using Version = STBDotNet.Elements.Version;

namespace STBDotNet.Serialization
{
    public static class Util
    {
        // public static string GetXmlNameSpace(XElement root)
        // {
        //     string xmlns = root.Attribute("xmlns") != null
        //         ? "{" + (string)root.Attribute("xmlns") + "}"
        //         : string.Empty;
        //
        //     return xmlns;
        // }
        //
        // public static IEnumerable<XElement> GetXElements(XDocument xDocument, string xmlns, IReadOnlyList<string> stbTag, Version version)
        // {
        //     string tag;
        //     switch (version)
        //     {
        //         case Version.Stb1:
        //             tag = stbTag[0];
        //             break;
        //         case Version.Stb2:
        //             tag = stbTag[1];
        //             break;
        //         default:
        //             throw new ArgumentOutOfRangeException(nameof(version), version, null);
        //     }
        //     IEnumerable<XElement> xElems = xDocument.Root?.Descendants(xmlns + tag);
        //
        //     return xElems;
        // }
        //
        // public static Version GetStbVersion(XElement root)
        // {
        //     var tmp = (string)root.Attribute("version");
        //     switch (tmp.Split('.')[0])
        //     {
        //         case "1":
        //             return Version.Stb1;
        //         case "2":
        //             return Version.Stb2;
        //         default:
        //             throw new ArgumentException("The STB version is not set");
        //     }
        // }
        //
        // public static List<int> GetNodeIdList(XElement items)
        // {
        //     var idList = new List<int>();
        //
        //     IEnumerable<XNode> nodes = items.Nodes();
        //     foreach (XElement node in nodes)
        //     {
        //         idList.Add((int)node.Attribute("id"));
        //     }
        //
        //     return idList;
        // }
        //
        // public static StrengthConcrete GetStrengthConcrete(string concreteName)
        // {
        //     switch (concreteName)
        //     {
        //         case "FC18": return StrengthConcrete.Fc18;
        //         case "FC21": return StrengthConcrete.Fc21;
        //         case "FC24": return StrengthConcrete.Fc24;
        //         case "FC27": return StrengthConcrete.Fc27;
        //         case "FC30": return StrengthConcrete.Fc30;
        //         case "FC33": return StrengthConcrete.Fc33;
        //         case "FC36": return StrengthConcrete.Fc36;
        //         case "FC40": return StrengthConcrete.Fc40;
        //         case "FC42": return StrengthConcrete.Fc42;
        //         case "FC45": return StrengthConcrete.Fc45;
        //         case "FC50": return StrengthConcrete.Fc50;
        //         case "FC55": return StrengthConcrete.Fc55;
        //         case "FC60": return StrengthConcrete.Fc60;
        //         case "FC70": return StrengthConcrete.Fc70;
        //         case "FC80": return StrengthConcrete.Fc80;
        //         case "FC90": return StrengthConcrete.Fc90;
        //         case "FC100": return StrengthConcrete.Fc100;
        //         default: return StrengthConcrete.Other;
        //     }
        // }
        //
        // public static StrengthBar GetStrengthBar(string barName)
        // {
        //     switch (barName)
        //     {
        //         case "SR235":
        //             return StrengthBar.S235;
        //         case "SD295":
        //         case "SD295A":
        //             return StrengthBar.S295;
        //         case "SD345":
        //             return StrengthBar.S345;
        //         case "SHD685":
        //             return StrengthBar.S685;
        //         case "KSS785":
        //         case "UB785":
        //         case "KW785":
        //         case "MK785":
        //             return StrengthBar.S785;
        //         case "SBPD1275":
        //         case "SBPDN1275":
        //             return StrengthBar.S1275;
        //         default:
        //             return StrengthBar.Other;
        //     }
        // }
    }
}