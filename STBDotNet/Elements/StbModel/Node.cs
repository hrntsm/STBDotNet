using System;
using System.Collections.Generic;
using System.Xml.Linq;
using STBDotNet.Geometry;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public class Node : StbSerializable, IGuid
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public Point Position { get; set; }
        public NodeKind NodeKind { get; set; }
        public int IdMember { get; set; }
        private static string[] StbTag { get; } = {"StbNodes", "StbNodes"};

        public void Deserialize(XNode xNode, Version version, string xmlns)
        {
            var xElements = (XElement) xNode;
            Id = (int)xElements.Attribute("id");
            Position = new Point
            {
                X = (double) xElements.Attribute("x"),
                Y = (double) xElements.Attribute("y"),
                Z = (double) xElements.Attribute("z")
            };
            NodeKind = GetNodeKind((string) xElements.Attribute("kind"));
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