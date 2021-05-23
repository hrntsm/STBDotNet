using System.Text;
using System.Xml.Serialization;
using STBDotNet.v140.StbCommon;
using STBDotNet.v140.StbFromIfc;
using STBDotNet.v140.StbModel;
using StbExtensions = STBDotNet.v140.StbExtension.StbExtensions;

namespace STBDotNet.v140
{
    [XmlRoot("ST_BRIDGE")]
    public class StbElements
    {
        [XmlAttribute("version")] public string Version { get; set; }
        [XmlElement("StbCommon")] public StbCommon.StbCommon Common { get; set; } = new StbCommon.StbCommon();
        [XmlElement("StbModel")] public StbModel.StbModel Model { get; set; } = new StbModel.StbModel();
        [XmlElement("StbFromIfc")] public StbFromIfc.StbFromIfc FromIfc { get; set; } = new StbFromIfc.StbFromIfc();
        [XmlElement("StbExtensions")] public StbExtensions Extensions { get; set; } = new StbExtensions();

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