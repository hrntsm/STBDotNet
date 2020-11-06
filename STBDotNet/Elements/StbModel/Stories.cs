using System.Collections.Generic;

namespace STBDotNet.Elements.StbModel
{
    public class Story : ModelBase
    {
        public double Height { get; set; }
        public StoryKind StoryKind { get; set; }
        public int IdDependence { get; set; }
        public StrengthConcrete StrengthConcrete { get; set; }
        public List<int> NodeIdList { get; set; }
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