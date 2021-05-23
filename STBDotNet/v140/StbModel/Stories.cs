using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace STBDotNet.v140.StbModel
{
    public class Story
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("height")] public double Height { get; set; }
        [XmlAttribute("kind")] public string Kind { get; set; }
        [XmlAttribute("concrete_strength")] public string ConcreteStrength { get; set; }
        [XmlIgnore] public StoryKind StoryKind { get; set; }
        [XmlIgnore] public StrengthConcrete StrengthConcrete { get; set; }
        [XmlArray("StbNodeid_List")]
        [XmlArrayItem("StbNodeid")]
        public List<NodeId> NodeIdList { get; set; }

        private StoryKind GetStoryKind(string kindName)
        {
            switch (kindName)
            {
                case "GENERAL":
                    return StoryKind.General;
                case "BASEMENT":
                    return StoryKind.Basement;
                case "ROOF":
                    return StoryKind.Roof;
                case "PENTHOUSE":
                    return StoryKind.Penthouse;
                case "ISOLATION":
                    return StoryKind.Isolation;
                default:
                    throw new ArgumentException("Undefined story kind");
            }
        }

        public override string ToString()
        {
            int nodeCount = NodeIdList?.Count ?? 0;
            return $"{Name} Height:{Height}, Nodes:{nodeCount}";
        }
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