using System.Collections.Generic;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public abstract class SectionBase:StbSerializable, IModel, ISection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public string Guid { get; set; }
    }

    public abstract class RcSection:SectionBase, IBarArrangement
    {
        public List<string> DBarMain { get; set; }
        public List<string> DBarBand { get; set; }
        public List<double> BatList { get; set; }
    }

    public abstract class SteelSectionBase : StbSerializable, IModel, ISteelSection
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public ShapeType ShapeType { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }
        public double P6 { get; set; }
    }
}