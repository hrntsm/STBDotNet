using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace STBDotNet.v140.StbModel.StbSection
{
    public class BeamRc : RcSection, ISecBeam, IStbSerializable
    {
        [XmlAttribute("kind_beam")] public string KindBeam { get; set; }
        [XmlAttribute("isFoundation")] public string IsFoundation { get; set; }
        [XmlAttribute("isCanti")] public string IsCanti { get; set; }
        [XmlAttribute("isOutIn")] public string IsOutIn { get; set; }
        [XmlAttribute("D_stirrup")] public string DStirrup { get; set; }
        [XmlAttribute("D_reinforcement_web")] public string DBarWeb { get; set; }
        [XmlAttribute("strength_stirrup")] public string StrengthStirrup { get; set; }
        [XmlAttribute("strength_reinforcement_web")] public string StrengthBarWeb { get; set; }
        [XmlAttribute("depth_cover_left")] [DefaultValue(0d)] public double DepthCoverLeft { get; set; }
        [XmlAttribute("depth_cover_right")] [DefaultValue(0d)] public double DepthCoverRight { get; set; }
        [XmlAttribute("depth_cover_top")] [DefaultValue(0d)] public double DepthCoverTop { get; set; }
        [XmlAttribute("depth_cover_bottom")] [DefaultValue(0d)] public double DepthCoverBottom { get; set; }
        [XmlAttribute("center_reinforcement_top")] [DefaultValue(0d)] public double CenterBarTop { get; set; }
        [XmlAttribute("center_reinforcement_bottom")] [DefaultValue(0d)] public double CenterBarBottom { get; set; }
        [XmlAttribute("bar_length_start")] [DefaultValue(0d)] public double BarLengthStart { get; set; }
        [XmlAttribute("bar_length_end")] [DefaultValue(0d)] public double BarLengthEnd { get; set; }
        // child element
        [XmlElement("StbSecFigure")] public RcBeamSecFigure Figure { get; set; }
        [XmlElement("StbSecBar_Arrangement")] public RcBeamSecBarArrangement BarArrangement { get; set; }
        [XmlIgnore] public RcBeamFigureType FigureType { get; private set; }

        public void OnAfterDeserialize()
        {
            if (Figure.SecStraight != null)
            {
                FigureType = RcBeamFigureType.Straight;
            }
            else if (Figure.SecTaper != null)
            {
                FigureType = RcBeamFigureType.Taper;
            }
            else if (Figure.SecHaunch != null)
            {
                FigureType = RcBeamFigureType.Haunch;
            }
            else
            {
                throw new ArgumentException("No figure type are defined.");
            }
        }


        public void OnBeforeSerialize()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Id:{Id} {Name}, Type:BeamRc, DMain:{DBarMain}, DStirrup:{DStirrup}";
        }
    }

    public enum RcBeamFigureType
    {
        Straight,
        Taper,
        Haunch
    }

    public class RcBeamSecFigure
    {
        [XmlElement("StbSecStraight")] public Straight SecStraight { get; set; }
        [XmlElement("StbSecTaper")] public Taper SecTaper { get; set; }
        [XmlElement("StbSecHaunch")] public Haunch SecHaunch { get; set; }

        public class Straight
        {
            [XmlAttribute("width")] public double Width { get; set; }
            [XmlAttribute("depth")] public double Depth { get; set; }
        }

        public class Taper
        {
            [XmlAttribute("width_start")] public double WidthStart { get; set; }
            [XmlAttribute("depth_start")] public double DepthStart { get; set; }
            [XmlAttribute("width_end")] public double WidthEnd { get; set; }
            [XmlAttribute("depth_end")] public double DepthEnd { get; set; }
        }

        public class Haunch : Taper
        {
            [XmlAttribute("width_center")] public double WidthCenter { get; set; }
            [XmlAttribute("depth_center")] public double DepthCenter { get; set; }
        }
    }

    public class RcBeamSecBarArrangement
    {
        [XmlElement("StbSecBeam_Same_Section")] public Same SameSection { get; set; }
        [XmlElement("StbSecBeam_Start_End_Section")] public StartEnd[] StartEndSection { get; set; }
        [XmlElement("StbSecBeam_Start_Center_End_Section")] public StartCenterEnd[] StartCenterEndSection { get; set; }
        [XmlElement("StbSecBeam_XReinforced")] public XReinforced XBarSection { get; set; }

        public class Same
        {
            [XmlAttribute("count_main_top_1st")] public int CountMainTop1st { get; set; }
            [XmlAttribute("count_main_top_2nd")] [DefaultValue(0)] public int CountMainTop2nd { get; set; }
            [XmlAttribute("count_main_top_3rd")] [DefaultValue(0)] public int CountMainTop3rd { get; set; }
            [XmlAttribute("count_main_bottom_1st")] public int CountMainBottom1st { get; set; }
            [XmlAttribute("count_main_bottom_2nd")] [DefaultValue(0)] public int CountMainBottom2nd { get; set; }
            [XmlAttribute("count_main_bottom_3rd")] [DefaultValue(0)] public int CountMainBottom3rd { get; set; }
            [XmlAttribute("count_2nd_main_top_1st")] [DefaultValue(0)] public int Count2ndMainTop1st { get; set; }
            [XmlAttribute("count_2nd_main_top_2nd")] [DefaultValue(0)] public int Count2ndMainTop2nd { get; set; }
            [XmlAttribute("count_2nd_main_top_3rd")] [DefaultValue(0)] public int Count2ndMainTop3rd { get; set; }
            [XmlAttribute("count_2nd_main_bottom_1st")] [DefaultValue(0)] public int Count2ndMainBottom1st { get; set; }
            [XmlAttribute("count_2nd_main_bottom_2nd")] [DefaultValue(0)] public int Count2ndMainBottom2nd { get; set; }
            [XmlAttribute("count_2nd_main_bottom_3rd")] [DefaultValue(0)] public int Count2ndMainBottom3rd { get; set; }
            [XmlAttribute("count_stirrup")] public int CountStirrup { get; set; }
            [XmlAttribute("pitch_stirrup")] public double PitchStirrup { get; set; }
            [XmlAttribute("count_web")] [DefaultValue(0)] public int CountWeb { get; set; }
            [XmlAttribute("count_bar_spacing")] [DefaultValue(0)] public int CountBarSpacing { get; set; }
            [XmlAttribute("pitch_bar_spacing")] [DefaultValue(0d)] public double PitchBarSpacing { get; set; }
        }

        public class StartEnd : Same
        {
            [XmlAttribute("pos")] public string Position { get; set; }
        }

        public class StartCenterEnd : Same
        {
            [XmlAttribute("pos")] public string Position { get; set; }
        }

        public class XReinforced
        {
            [XmlAttribute("count_main_top")] public int CountMainTop { get; set; }
            [XmlAttribute("count_main_bottom")] public int CountMainBottom { get; set; }
        }
    }
}