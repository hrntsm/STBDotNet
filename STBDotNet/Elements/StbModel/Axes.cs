using System.Collections.Generic;

namespace STBDotNet.Elements.StbModel
{
    public class Axes
    {
        public List<ParallelAxes> ParallelAxes { get; set; }
        public List<ArcAxes> ArcAxes { get; set; }
        public List<RadialAxes> RadialAxes { get; set; }
        public DrawingAxes DrawingAxes { get; set; }
    }

    public class ParallelAxes:IStbTag, IAxis
    {
        public string[] StbTag { get; } = {"", "StbParallelAxes"};
        public string GroupName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Angle { get; set; }
        public List<ParallelAxis> ParallelAxis { get; set; }
    }

    public interface IAxis
    {
        string GroupName { get; set; }
        double X { get; set; }
        double Y { get; set; }
    }

    public class ParallelAxis:ModelBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbX_Axis", "StbY_Axis", "StbParallelAxis"};
        public double Distance { get; set; }
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
}