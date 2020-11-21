using System;
using System.Collections.Generic;
using System.Xml.Linq;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public class Story : ModelBase
    {
        public double Height { get; set; }
        public StoryKind StoryKind { get; set; }
        public int IdDependence { get; set; }
        public StrengthConcrete StrengthConcrete { get; set; }
        public List<int> NodeIdList { get; set; }

        public void Deserialize(XNode xNode, Version version, string xmlns)
        {
            var xElements = (XElement)xNode;
            Id = (int) xElements.Attribute("id");
            Name = (string) xElements.Attribute("name");
            Height = (double) xElements.Attribute("height");
            StrengthConcrete = Util.GetStrengthConcrete((string) xElements.Attribute("concrete_strength"));
            StoryKind = GetStoryKind((string) xElements.Attribute("kind"));
            NodeIdList = Util.GetNodeIdList(xElements.Element("StbNodeid_List"));
        }

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