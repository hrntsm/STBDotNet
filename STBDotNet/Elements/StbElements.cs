using System.Xml.Linq;
using STBDotNet.Serialization;
using STBDotNet.Elements.StbModel;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbFromIfc;
using Extensions = STBDotNet.Elements.StbExtension.Extensions;

namespace STBDotNet.Elements
{
    public class StbElements : StbSerializable
    {
        public Version Version { get; set; }
        public Common Common { get; set; } = new Common();
        public Model Model { get; set; } = new Model();
        public FromIfc FromIfc { get; set; } = new FromIfc();
        public Extensions Extensions { get; set; } = new Extensions();


        protected override void SetProperties(XDocument xDocument, Version version, string xmlns)
        {
            Version = version;
            Common.Deserialize(xDocument, version, xmlns);
            Model.Deserialize(xDocument, version, xmlns);
            FromIfc.Deserialize(xDocument, version, xmlns);
            Extensions.Deserialize(xDocument, version, xmlns);
        }
    }

    public enum Version
    {
        Stb1,
        Stb2
    }
}