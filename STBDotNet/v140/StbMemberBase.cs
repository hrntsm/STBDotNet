using System.Collections.Generic;
using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public abstract class StbMemberBase : IModel, IMemberBase
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("id_section")] public int IdSection { get; set; }
        [XmlAttribute("kind_structure")] public string Kind { get; set; }
        [XmlIgnore] public KindStructure KindStructure { get; set; }
    }

    public abstract class PlateBase : StbMemberBase, IPlate
    {
        [XmlArray("StbNodeid_List")]
        [XmlArrayItem("StbNodeid")] public List<NodeId> NodeIdList { get; set; }
        [XmlElement("StbOpen")] public List<Open> Opens { get; set; }
    }

    public interface IPlate : IMemberBase
    {
        List<NodeId> NodeIdList { get; set; }
        List<Open> Opens { get; set; }
    }

    public class PlaneOpen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdSection { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double LengthX { get; set; }
        public double LengthY { get; set; }
        public double Rotate { get; set; }
    }

    public interface IMemberBase
    {
        int IdSection { get; set; }
        string Kind { get; set; }
        KindStructure KindStructure { get; set; }
    }

    public interface IFrameIdNode
    {
        int IdNodeStart { get; set; }
        int IdNodeEnd { get; set; }
    }

    public interface IFrame : IMemberBase
    {
        string Name { get; set; }
        double Rotate { get; set; }
        double OffsetStartX { get; set; }
        double OffsetStartY { get; set; }
        double OffsetStartZ { get; set; }
        double OffsetEndX { get; set; }
        double OffsetEndY { get; set; }
        double OffsetEndZ { get; set; }
        string ConditionStart { get; set; }
        string ConditionEnd { get; set; }
        double JointStart { get; set; }
        double JointEnd { get; set; }
        string KindJointStart { get; set; }
        string KindJointEnd { get; set; }
        int JointIdStart { get; set; }
        int JointIdEnd { get; set; }
    }

    public enum KindStructure
    {
        Rc,
        S,
        Src,
        Cft
    }

    public enum KindSlab
    {
        Rc,
        Deck,
        Precast
    }
}