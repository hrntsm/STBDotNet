using System.Collections.Generic;
using STBDotNet.Elements.Base;

namespace STBDotNet.Elements.StbModel
{
    public class Story : ModelBase
    {
        public double Height { get; set; }
        public StoryKind StoryKind { get; set; }
        public int IdDependence { get; set; }
        public string StrengthConcrete { get; set; }
        public List<NodeId> NodeIds { get; set; }
    }

    public enum StoryKind
    {
        General,
        Basement,
        Roof,
        Penthouse,
        Isolation,
        Dependence
    }
}