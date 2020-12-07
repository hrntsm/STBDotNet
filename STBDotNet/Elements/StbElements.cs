using System.Xml.Serialization;
using STBDotNet.Elements.StbModel;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbFromIfc;
using Extensions = STBDotNet.Elements.StbExtension.Extensions;

namespace STBDotNet.Elements
{
    [XmlRoot("ST_BRIDGE")]
    public class StbElements
    {
        [XmlAttribute("version")] public string Version { get; set; }
        [XmlElement("StbCommon")] public Common Common { get; set; } = new Common();
        [XmlElement("StbModel")] public Model Model { get; set; } = new Model();
        [XmlElement("StbFromIfc")] public FromIfc FromIfc { get; set; } = new FromIfc();
        [XmlElement("StbExtensions")] public Extensions Extensions { get; set; } = new Extensions();
    }

    public enum Version
    {
        Stb1,
        Stb2
    }
}