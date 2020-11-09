using System.Collections.Generic;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public interface ISection
    {
        int Id { get; set; }
        string Floor { get; set; }
    }

    public interface IKindColumn
    {
        KindColumn KindColumn { get; set; }
    }

    public interface IStrengthConcrete
    {
        StrengthConcrete StrengthConcrete { get; set; }
    }

    public interface IStrengthSteel
    {
        StrengthSteel StrengthSteel { get; set; }
    }

    public interface IBarArrangement
    {
        List<string> DBarMain { get; set; }
        List<string> DBarBand { get; set; }
        List<double> BatList { get; set; }
    }
    
    public interface ISteelSection
    {
        ShapeType ShapeType { get; set; }
        double P1 { get; set; }
        double P2 { get; set; }
        double P3 { get; set; }
        double P4 { get; set; }
        double P5 { get; set; }
        double P6 { get; set; }
    }
}