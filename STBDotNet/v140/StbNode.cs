using System;
using System.Xml.Serialization;
using STBDotNet.Geometry;

namespace STBDotNet.v140.StbModel
{
    public class StbNode : NodeId, IStbSerializable
    {
        [XmlAttribute("x")] public double X { get; set; }
        [XmlAttribute("y")] public double Y { get; set; }
        [XmlAttribute("z")] public double Z { get; set; }
        [XmlAttribute("kind")] public string Kind { get; set; }
        [XmlIgnore] public Point3 Position { get; set; }
        [XmlIgnore] public NodeKind NodeKind { get; set; }

        public void OnAfterDeserialize()
        {
            Position = new Point3(X, Y, Z);
            NodeKind = GetNodeKind(Kind);
        }

        public void OnBeforeSerialize()
        {
            X = Position.X;
            Y = Position.Y;
            Z = Position.Z;
            Kind = SetNodeKind(NodeKind);
        }

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

        private string SetNodeKind(NodeKind nodeKind)
        {
            switch (nodeKind)
            {
                case NodeKind.OnGirder:
                    return "ON_GRID";
                case NodeKind.OnBeam:
                    return "ON_BEAM";
                case NodeKind.OnColumn:
                    return "ON_COLUMN";
                case NodeKind.OnPost:
                    return "ON_POST";
                case NodeKind.OnGrid:
                    return "ON_GRID";
                case NodeKind.OnCanti:
                    return "ON_CANTI";
                case NodeKind.OnSlab:
                    return "ON_SLAB";
                case NodeKind.Other:
                    return "ON_OTHER";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return $"Id:{Id}({X}, {Y}, {Z})";
        }
    }

    public class NodeId
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        public NodeId()
        { }

        public NodeId(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Id:{Id}";
        }
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