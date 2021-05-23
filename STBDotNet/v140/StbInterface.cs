using STBDotNet.Enums;

namespace STBDotNet.v140
{
    public interface ISection
    {
        int Id { get; set; }
        string Floor { get; set; }
    }

    public interface ISecColumn
    {
        string KindColumn { get; set; }
    }

    public interface ISecBeam
    {
        string KindBeam { get; set; }
        string IsCanti { get; set; }
        string IsOutIn { get; set; }
    }

    public interface ISecBrace
    {
        string KindBeam { get; set; }
    }

    public interface IJointId
    {
        int JointIdStart { get; set; }
        int JointIdEnd { get; set; }
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
        // Size
        string DBarMain { get; set; }
        string DBar2ndMain { get; set; }
        string DBarAxial { get; set; }
        string DBarBand { get; set; }
        string DBarSpacing { get; set; }
        // Strength
        string StrengthBarMain { get; set; }
        string StrengthBar2ndMain { get; set; }
        string StrengthBarAxial { get; set; }
        string StrengthBarBand { get; set; }
        string StrengthBarSpacing { get; set; }
        // Position
        string KindBarCorner { get; set; }
        double IntervalBar { get; set; }
        double CenterBarStartX { get; set; }
        double CenterBarStartY { get; set; }
        double CenterBarEndX { get; set; }
        double CenterBarEndY { get; set; }
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