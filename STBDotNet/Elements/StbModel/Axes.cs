using System;
using System.Collections.Generic;
using System.Xml.Linq;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public class Axes : StbSerializable
    {
        public List<ParallelAxes> ParallelAxes { get; set; } = new List<ParallelAxes>();
        public List<ArcAxes> ArcAxes { get; set; } = new List<ArcAxes>();
        public List<RadialAxes> RadialAxes { get; set; } = new List<RadialAxes>();
        public DrawingAxes DrawingAxes { get; set; } = new DrawingAxes();

        public void Deserialize(XElement element, Version version, string xmlns)
        {
            XElement items = element.Element("StbAxes");
            IEnumerable<XNode> xNodes = items.Nodes();
            var XAxes = new ParallelAxes { GroupName = "X_Axis", X = 0d, Y = 0d, Angle = 0d };
            var YAxes = new ParallelAxes { GroupName = "Y_Axis", X = 0d, Y = 0d, Angle = 0d };
            
            foreach (XNode xNode in xNodes)
            {
                var xElements = (XElement)xNode;
                switch (xElements.Name.ToString())
                {
                    case "StbX_Axis":
                        XAxes.ParallelAxis.Add(GetParallelAxis(xElements));
                        break;
                    case "StbY_Axis":
                        YAxes.ParallelAxis.Add(GetParallelAxis(xElements));
                        break;
                    default:
                        throw new ArgumentException("Undefined axis type");
                }
            }
            ParallelAxes.Add(XAxes);
            ParallelAxes.Add(YAxes);
        }

        private ParallelAxis GetParallelAxis(XElement xElements)
        {
            return new ParallelAxis
            {
                Distance = (double)xElements.Attribute("distance"),
                Name = (string)xElements.Attribute("name"),
                Id = (int)xElements.Attribute("id"),
                NodeIdList = Util.GetNodeIdList(xElements.Element("StbNodeid_List"))
            };
        }
    }

    public class ParallelAxes:IStbTag, IAxis
    {
        public string[] StbTag { get; } = {"StbAxis", "StbParallelAxes"};
        public string GroupName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Angle { get; set; }
        public List<ParallelAxis> ParallelAxis { get; set; } = new List<ParallelAxis>();
    }

    public class ParallelAxis:ModelBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbX_Axis", "StbY_Axis", "StbParallelAxis"};
        public double Distance { get; set; }
        public List<int> NodeIdList { get; set; }
    }

    public class ArcAxes:IArcAxis, IStbTag
    {
        public string[] StbTag { get; } = {"", "StbArcAxes"};
        public string GroupName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double StartAngle { get; set; }
        public double EndAngle { get; set; }
        public List<ArcAxis> ArcAxis { get; set; }
    }

    public class ArcAxis:ModelBase, IStbTag
    {
        public string[] StbTag { get; } = {"", "StbArcAxis"};
        public double Radius { get; set; }
    }

    public class RadialAxes:IStbTag, IAxis
    {
        public string[] StbTag { get; } = {"", "StbRadialAxes"};
        public string GroupName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public List<RadialAxis> RadialAxis { get; set; }
    }

    public class RadialAxis:ModelBase, IStbTag
    {
        public string[] StbTag { get; } = {"", "StbRadialAxis"};
        public double Angle { get; set; }
    }

    public class DrawingAxes:IStbTag
    {
        public string[] StbTag { get; } = {"", "StbDrawingAxes"};
        public List<DrawingLineAxis> LineAxis { get; set; }
        public List<DrawingArcAxis> ArcAxis { get; set; }
    }

    public class DrawingLineAxis:IStbTag
    {
        public string[] StbTag { get; } = {"StbDrawingAxis", "StbDrawingLineAxis"};
        public string Name { get; set; }
        public string GroupName { get; set; }
        public double StartX { get; set; }
        public double StartY { get; set; }
        public double EndX { get; set; }
        public double EndY { get; set; }
    }

    public class DrawingArcAxis:IStbTag, IArcAxis
    {
        public string[] StbTag { get; } = {"", "StbDrawingArcAxis"};
        public string Name { get; set; }
        public double Radius { get; set; }
        public string GroupName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double StartAngle { get; set; }
        public double EndAngle { get; set; }
    }

    public interface IArcAxis:IAxis
    {
        double StartAngle { get; set; }
        double EndAngle { get; set; }
    }

    public interface IAxis
    {
        string GroupName { get; set; }
        double X { get; set; }
        double Y { get; set; }
    }
}