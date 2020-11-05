using System.Collections.Generic;

namespace STBDotNet.Elements.StbModel.StbMember
{
    public class Members
    {
        public List<Column> Columns { get; set; } = new List<Column>();
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Girder> Girders { get; set; } = new List<Girder>();
        public List<Beam> Beams { get; set; } = new List<Beam>();
        public List<Brace> Braces { get; set; } = new List<Brace>();
        public List<Slab> Slabs { get; set; } = new List<Slab>();
        public List<Wall> Walls { get; set; } = new List<Wall>();
        public List<Footing> Footings { get; set; } = new List<Footing>();
        public List<StripFooting> StripFootings { get; set; } = new List<StripFooting>();
        public List<Pile> Piles { get; set; } = new List<Pile>();
        public List<FoundationColumn> FoundationColumns { get; set; } = new List<FoundationColumn>();
        public List<Parapet> Parapets { get; set; } = new List<Parapet>();
        public List<Open> Opens { get; set; } = new List<Open>();
    }

    public class Column:FrameBase
    {
    }

    public class Post:FrameBase
    {
    }

    public class Girder:FrameBase
    {
    }

    public class Beam:FrameBase
    {
    }

    public class Brace:FrameBase
    {
    }

    public class Slab:PlateBase
    {
        public double Level { get; set; }
    }

    public class Wall:PlateBase
    {
    }

    public class Footing:MemberBase
    {
    }

    public class StripFooting:MemberBase
    {
    }

    public class Pile:MemberBase
    {
    }

    public class FoundationColumn:MemberBase
    {
    }

    public class Parapet:MemberBase
    {
    }

    public class Open:MemberBase
    {
    }
}