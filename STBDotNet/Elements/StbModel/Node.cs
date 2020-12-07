using System.Xml.Serialization;
using STBDotNet.Geometry;

namespace STBDotNet.Elements.StbModel
{
    public class Node : NodeId
    {
        [XmlAttribute("x")] public double X { get; set; }
        [XmlAttribute("y")] public double Y { get; set; }
        [XmlAttribute("z")] public double Z { get; set; }
        [XmlAttribute("kind")] public string Kind { get; set; }
        [XmlIgnore] public Point Position { get; set; }
        [XmlIgnore] public NodeKind NodeKind { get; set; }

        private NodeKind GetNodeKind(string kindString)
        {
            switch (kindString)
            {
                case "ON_BEAM":
                    return NodeKind.OnBeam;
                case "ON_COLUMN":
                    return NodeKind.OnColumn;
                case "ON_GRID": 
                    return NodeKind.OnGrid;
                case "ON_CANTI":
                    return NodeKind.OnCanti;
                case "ON_SLAB": 
                    return NodeKind.OnSlab;
                default: return NodeKind.Other;
            }
        }
    }

    public class NodeId
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }

    public enum NodeKind
    {
        OnGirder,
        OnBeam,
        OnColumn,
        OnPost,
        OnGrid,
        OnCanti,
        OnSlab,
        Other
    }
}