using System.Text;
using System.Xml.Serialization;

namespace STBDotNet.v140
{
    [XmlRoot("ST_BRIDGE")]
    public class StbBridge140
    {
        [XmlAttribute("version")] public string Version { get; set; }
        [XmlElement("StbCommon")] public StbCommon Common { get; set; } = new StbCommon();
        [XmlElement("StbModel")] public StbModel Model { get; set; } = new StbModel();
        [XmlElement("StbFromIfc")] public StbFromIfc FromIfc { get; set; } = new StbFromIfc();
        [XmlElement("StbExtensions")] public StbExtensions Extensions { get; set; } = new StbExtensions();

        public override string ToString()
        {
            int numAxis = Model.Axes?.Count ?? 0;
            int numStory = Model.Stories?.Count ?? 0;
            int numColumn = Model.StbMembers.Columns?.Count ?? 0;
            int numPost = Model.StbMembers.Posts?.Count ?? 0;
            int numGirder = Model.StbMembers.Girders?.Count ?? 0;
            int numBeam = Model.StbMembers.Beams?.Count ?? 0;
            int numBrace = Model.StbMembers.Braces?.Count ?? 0;

            var sb = new StringBuilder();
            sb.Append($"Stb version:{Version} \n");
            sb.Append($"StbNode:{Model.Nodes.Count}, StbAxis:{numAxis}, StbStory:{numStory}\n");
            sb.Append($"Column:{numColumn}, Post:{numPost}, Girder:{numGirder}, Beam:{numBeam}, Brace:{numBrace}\n");
            sb.Append($"StbSection:{Model.Sections.Count}");
            return sb.ToString();
        }
    }
}