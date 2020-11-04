using System.Collections.Generic;
using STBDotNet.Elements.Base;
using STBDotNet.Elements.Geometry;

namespace STBDotNet.Elements.StbModel
{
    public class Node: IGuid
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public Point Position { get; set; }
        public NodeKind NodeKind { get; set; }
        public int IdMember { get; set; }
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