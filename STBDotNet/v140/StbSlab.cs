using System.ComponentModel;
using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public abstract class SlabSecBase : StbSection, IModel
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("strength_concrete")] public string StrengthConcrete { get; set; }
        [XmlAttribute("depth_cover_top")] [DefaultValue(0d)] public double DepthCoverTop { get; set; }
    }

    public class StbSecSlabRc : SlabSecBase
    {
        [XmlAttribute("isFoundation")] [DefaultValue(false)] public string IsFoundation { get; set; }
        [XmlAttribute("isEarthen")] [DefaultValue(false)] public string IsEarthen { get; set; }
        [XmlAttribute("isCanti")] [DefaultValue(false)] public string IsCanti { get; set; }
        [XmlAttribute("depth_cover_bottom")] [DefaultValue(0d)] public double DepthCoverBottom { get; set; }
        // child element
        [XmlElement("StbSecFigure")] public SlabSecFigure Figure { get; set; }
        [XmlElement("StbSecBar_Arrangement")] public SlabRcSecBarArrangement BarArrangement { get; set; }

        public class SlabSecFigure
        {
            [XmlElement("StbSecStraight")] public StraightSlab SecStraight { get; set; }
            [XmlElement("StbSecTaper")] public TaperedSlab SecTaper { get; set; }
            [XmlElement("StbSecHaunch")] public HaunchSlab SecHaunch { get; set; }

            public class StraightSlab
            {
                [XmlAttribute("depth")] public double Depth { get; set; }
            }

            public class TaperedSlab
            {
                [XmlAttribute("depth_base")] public double DepthBase { get; set; }
                [XmlAttribute("depth_tip")] public double DepthTip { get; set; }
            }

            public class HaunchSlab
            {
                [XmlAttribute("depth_base")] public double DepthBase { get; set; }
                [XmlAttribute("depth_center")] public double DepthCenter { get; set; }
                [XmlAttribute("depth_haunch")] public double DepthHaunch { get; set; }
            }
        }

        public class SlabRcSecBarArrangement
        {
            [XmlElement("StbSecStandard_Slab")] public RcStandard[] StandardSlab { get; set; }
            [XmlElement("StbSec2Way_Slab")] public RcTwoWay[] TwoWaySlab { get; set; }
            [XmlElement("StbSec1Way_Slab_1")] public RcOneWay1[] OneWay1Slab { get; set; }
            [XmlElement("StbSec1Way_Slab_2")] public RcOneWay2[] OneWay2Slab { get; set; }

            public class RcStandard
            {
                [XmlAttribute("pos")] public string Position { get; set; }
                [XmlAttribute("strength")] public string Strength { get; set; }
                [XmlAttribute("D")] public string D { get; set; }
                [XmlAttribute("pitch")] public double Pitch { get; set; }
            }

            public class RcTwoWay : RcStandard
            { }

            public class RcOneWay1 : RcStandard
            { }

            public class RcOneWay2 : RcStandard
            { }
        }
    }

    public class StbSecSlabDeck : SlabSecBase
    {
        [XmlAttribute("product_type")] public string ProductType { get; set; }
        [XmlAttribute("depthConcrete")] public double DepthConcrete { get; set; }
        [XmlAttribute("depth_cover_bottom")] [DefaultValue(0d)] public double DepthCoverBottom { get; set; }
        // child element
        [XmlElement("StbSecBar_Arrangement")] public SlabDeckSecBarArrangement BarArrangement { get; set; }
        [XmlElement("StbSecDeck_Product")] public SlabDeckProduct Product { get; set; }

        public class SlabDeckSecBarArrangement
        {
            [XmlElement("StbSecStandard_Slab")] public DeckStandard[] StandardSlab { get; set; }
            [XmlElement("StbSec2Way_Slab")] public DeckTwoWay[] TwoWaySlab { get; set; }
            [XmlElement("StbSec1Way_Slab")] public DeckOneWay[] OneWay1Slab { get; set; }

            public class DeckStandard : StbSecSlabRc.SlabRcSecBarArrangement.RcStandard
            { }

            public class DeckTwoWay : DeckStandard
            { }

            public class DeckOneWay : DeckStandard
            { }
        }

        public class SlabDeckProduct
        {
            [XmlAttribute("product_company")] public string ProductCompany { get; set; }
            [XmlAttribute("product_code")] public string ProductCode { get; set; }
            [XmlAttribute("deck_depth")] public double DeckDepth { get; set; }
        }
    }

    public class StbSecSlabPrecast : SlabSecBase
    {
        [XmlAttribute("precast_type")] public string ProductType { get; set; }
        [XmlAttribute("depthConcrete")] public double DepthConcrete { get; set; }
        // child element
        [XmlElement("StbSecBar_Arrangement")] public SlabPrecastSecBarArrangement BarArrangement { get; set; }
        [XmlElement("StbSecDeck_Product")] public SlabPrecastProduct Product { get; set; }

        public class SlabPrecastSecBarArrangement : StbSecSlabDeck.SlabDeckSecBarArrangement
        { }

        public class SlabPrecastProduct
        {
            [XmlAttribute("product_company")] public string ProductCompany { get; set; }
            [XmlAttribute("product_name")] public string ProductName { get; set; }
            [XmlAttribute("product_code")] public string ProductCode { get; set; }
            [XmlAttribute("depth")] public double Depth { get; set; }
        }
    }
}