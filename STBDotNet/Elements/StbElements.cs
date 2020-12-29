using System.Text;
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

        public override string ToString()
        {
            int numAxis = Model.Axes?.Count ?? 0;
            int numStory = Model.Stories?.Count ?? 0;
            int numColumn = Model.Members.Columns?.Count ?? 0;
            int numPost = Model.Members.Posts?.Count ?? 0;
            int numGirder = Model.Members.Girders?.Count ?? 0;
            int numBeam = Model.Members.Beams?.Count ?? 0;
            int numBrace = Model.Members.Braces?.Count ?? 0;

            var sb = new StringBuilder();
            sb.Append($"Stb version:{Version} \n");
            sb.Append($"Node:{Model.Nodes.Count}, Axis:{numAxis}, Story:{numStory}\n");
            sb.Append($"Column:{numColumn}, Post:{numPost}, Girder:{numGirder}, Beam:{numBeam}, Brace:{numBrace}\n");
            sb.Append($"Section:{Model.Sections.Count}");
            return sb.ToString();
        }
    }

    public enum Version
    {
        Stb1,
        Stb2
    }
}