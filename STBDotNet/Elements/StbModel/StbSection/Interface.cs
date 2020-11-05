using System.Collections.Generic;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public interface ISection
    {
        public int Id { get; set; }
        public string Floor { get; set; }
    }

    public interface IKindColumn
    {
        public KindColumn KindColumn { get; set; }
    }

    public interface IStrengthConcrete
    {
        public StrengthConcrete StrengthConcrete { get; set; }
    }

    public interface IStrengthSteel
    {
        public StrengthSteel StrengthSteel { get; set; }
    }

    public interface IBarArrangement
    {
        public List<string> DBarMain { get; set; }
        public List<string> DBarBand { get; set; }
        public List<double> BatList { get; set; }
    }
    
    public interface ISteelSection
    {
        public ShapeType ShapeType { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }
        public double P6 { get; set; }
    }
}