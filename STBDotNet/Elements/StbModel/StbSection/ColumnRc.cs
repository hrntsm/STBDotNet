using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public class ColumnRc : RcSection, ISecColumn, IStbSerializable
    {
        [XmlAttribute("D_reinforcement_axial")] public string DBarAxial { get; set; }
        [XmlAttribute("D_reinforcement_band")] public string DBarBand { get; set; }
        [XmlAttribute("Strength_reinforcement_axial")] public string StrengthBarAxial { get; set; }
        [XmlAttribute("Strength_reinforcement_band")] public string StrengthBarBand { get; set; }
        [XmlAttribute("kind_reinforcement_corner")] public string KindBarCorner { get; set; }
        [XmlAttribute("center_reinforcement_start_X")] [DefaultValue(0d)] public double CenterBarStartX { get; set; }
        [XmlAttribute("center_reinforcement_start_Y")] [DefaultValue(0d)] public double CenterBarStartY { get; set; }
        [XmlAttribute("center_reinforcement_end_X")] [DefaultValue(0d)] public double CenterBarEndX { get; set; }
        [XmlAttribute("center_reinforcement_end_Y")] [DefaultValue(0d)] public double CenterBarEndY { get; set; }
        [XmlAttribute("kind_column")] public string KindColumn { get; set; }
        [XmlAttribute("depth_cover_start_X")] [DefaultValue(0d)] public double DepthCoverStartX { get; set; }
        [XmlAttribute("depth_cover_end_X")] [DefaultValue(0d)] public double DepthCoverEndX { get; set; }
        [XmlAttribute("depth_cover_start_Y")] [DefaultValue(0d)] public double DepthCoverStartY { get; set; }
        [XmlAttribute("depth_cover_end_Y")] [DefaultValue(0d)] public double DepthCoverEndY { get; set; }
        // child element
        [XmlElement("StbSecFigure")] public RcColumnSecFigure Figure { get; set; }
        [XmlElement("StbSecBar_Arrangement")] public RcColumnSecBarArrangement BarArrangement { get; set; }
        [XmlIgnore] public RcColumnFigureType FigureType { get; private set; }

        public void OnAfterDeserialize()
        {
            FigureType = Figure.SecRect == null ? RcColumnFigureType.Circle : RcColumnFigureType.Rectangle;
        }

        public void OnBeforeSerialize()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Id:{Id} {Name}, Type:ColRc, DMain:{DBarMain}, DBand:{DBarBand}";
        }
    }

    public class RcColumnSecFigure
    {
        [XmlElement("StbSecRect")] public Rectangle SecRect { get; set; }
        [XmlElement("StbSecCircle")] public Circle SecCircle { get; set; }

        public class Rectangle
        {
            [XmlAttribute("DX")] public double DX { get; set; }
            [XmlAttribute("DY")] public double DY { get; set; }
        }

        public class Circle
        {
            [XmlAttribute("D")] public double D { get; set; }
        }
    }

    public class RcColumnSecBarArrangement
    {
        [XmlElement("StbSecRect_Column_Same")] public RectSame RectSameSection { get; set; }
        [XmlElement("StbSecRect_Column_Not_Same")] public RectNotSame[] RectNotSameSection { get; set; }
        [XmlElement("StbSecCircle_Column_Same")] public CircleSame CircleSameSection { get; set; }
        [XmlElement("StbSecCircle_Column_Not_Same")] public CircleNotSame[] CircleNotSameSection { get; set; }
        [XmlElement("StbSecRect_Column_XReinforced")] public RectXReinforced XReinforced { get; set; }

        public class RectSame
        {
            [XmlAttribute("count_main_X_1st")] public int CountMainX1st { get; set; }
            [XmlAttribute("count_main_X_2nd")] [DefaultValue(0)] public int CountMainX2nd { get; set; }
            [XmlAttribute("count_main_Y_1st")] public int CountMainY1st { get; set; }
            [XmlAttribute("count_main_Y_2nd")] [DefaultValue(0)] public int CountMainY2nd { get; set; }
            [XmlAttribute("count_2nd_main_X_1st")] [DefaultValue(0)] public int Count2ndMainX1st { get; set; }
            [XmlAttribute("count_2nd_main_X_2nd")] [DefaultValue(0)] public int Count2ndMainX2nd { get; set; }
            [XmlAttribute("count_2nd_main_Y_1st")] [DefaultValue(0)] public int Count2ndMainY1st { get; set; }
            [XmlAttribute("count_2nd_main_Y_2nd")] [DefaultValue(0)] public int Count2ndMainY2nd { get; set; }
            [XmlAttribute("count_main_total")] public int CountMainTotal { get; set; }
            [XmlAttribute("count_axial")] [DefaultValue(0)] public int CountAxial { get; set; }
            [XmlAttribute("pitch_band")] public double PitchBand { get; set; }
            [XmlAttribute("count_band_dir_X")] public int CountBandDirX { get; set; }
            [XmlAttribute("count_band_dir_Y")] public int CountBandDirY { get; set; }
            [XmlAttribute("pitch_bar_spacing")] [DefaultValue(0d)] public double PitchBarSpacing { get; set; }
            [XmlAttribute("count_bar_spacing_X")] [DefaultValue(0)] public int CountBarSpacingX { get; set; }
            [XmlAttribute("count_bar_spacing_Y")] [DefaultValue(0)] public int CountBarSpacingY { get; set; }
        }

        public class RectNotSame : RectSame
        {
            [XmlAttribute("pos")] public string Position { get; set; }
        }

        public class CircleSame
        {
            [XmlAttribute("count_main")] public int CountMain { get; set; }
            [XmlAttribute("count_axial")] [DefaultValue(0)] public int CountAxial { get; set; }
            [XmlAttribute("count_band")] [DefaultValue(0)] public int CountBand { get; set; }
            [XmlAttribute("pitch_band")] public double PitchBand { get; set; }
            [XmlAttribute("pitch_bar_spacing")] [DefaultValue(0d)] public double PitchBarSpacing { get; set; }
            [XmlAttribute("count_bar_spacing_X")] [DefaultValue(0)] public int CountBarSpacingX { get; set; }
            [XmlAttribute("count_bar_spacing_Y")] [DefaultValue(0)] public int CountBarSpacingY { get; set; }
        }

        public class CircleNotSame : CircleSame
        {
            [XmlAttribute("pos")] public string Position { get; set; }
        }

        public class RectXReinforced
        {
            [XmlAttribute("count_main_X")] [DefaultValue(0)] public int CountMainX { get; set; }
            [XmlAttribute("count_main_Y")] [DefaultValue(0)] public int CountMainY { get; set; }
            [XmlAttribute("count_main_total")] [DefaultValue(0)] public int CountMainTotal { get; set; }
        }
    }

    public enum RcColumnFigureType
    {
        Rectangle,
        Circle
    }
}
