using System.Collections.Generic;
using System.Numerics;

namespace STBDotNet.Elements.StbModel.StbMember
{
    public abstract class MemberBase : IModel, IMember
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdSection { get; set; }
        public KindFrameStructure KindFrameStructure { get; set; }
    }

    public abstract class FrameBase : MemberBase, IFrame
    {
        public int IdNodeStart { get; set; }
        public int IdNodeEnd { get; set; }
        public int Rotate { get; set; }
    }

    public abstract class PlateBase : MemberBase, IPlate
    {
        public List<int> NodeIdOrder { get; set; } = new List<int>();
        public List<int> OpenIdList { get; set; } = new List<int>();
        public List<PlaneOpen> Open { get; set; } = new List<PlaneOpen>();
        public List<PlateOffset> OffsetList { get; set; } = new List<PlateOffset>();
    }

    public interface IPlate
    {
        List<int> NodeIdOrder { get; set; }
        List<int> OpenIdList { get; set; }
        List<PlaneOpen> Open { get; set; }
        List<PlateOffset> OffsetList { get; set; }
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
        public double Rotate { get;  set; }
    }

    public class PlateOffset
    {
        public int IdNode { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
    
    public interface IMember
    {
        int IdSection { get; set; }
        KindFrameStructure KindFrameStructure { get; set; }
    }

    public interface IFrame
    {
        int IdNodeStart { get; set; }
        int IdNodeEnd { get; set; }
    }
    
    public enum KindFrameStructure
    {
        Rc,
        S,
        Src,
        Cft
    }

    public enum KindSlabStructure
    {
        Rc,
        Deck,
        Precast
    }
}