using System.Collections.Generic;
using STBDotNet.Elements.Base;

namespace STBDotNet.Elements.StbModel
{
    public class NodeId
    {
        public int Id { get; set; }
    }

    public class NodeIdOrder
    {
        public List<int> Ids { get; set; }
    }
    
    public class Node: NodeId, IGuid
    {
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