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

    public class Column:FrameBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbColumn", "StbColumn"};
    }

    public class Post:FrameBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbPost", "StbPost"};
    }

    public class Girder:FrameBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbGirder", "StbGirder"};
    }

    public class Beam:FrameBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbBeam", "StbBeam"};
    }

    public class Brace:FrameBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbBrace", "StbBrace"};
    }

    public class Slab:PlateBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSlab", "StbSlab"};
        public double Level { get; set; }
    }

    public class Wall:PlateBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbWall", "StbWall"};
    }

    public class Footing:MemberBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbFooting", "StbFooting"};
    }

    public class StripFooting:MemberBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbStripFooting", "StbStripFooting"};
    }

    public class Pile:MemberBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbPile", "StbPile"};
    }

    public class FoundationColumn:MemberBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbFoundationColumn", "StbFoundationColumn"};
    }

    public class Parapet:MemberBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbParapet", "StbParapet"};
    }

    public class Open:MemberBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbOpen", "StbOpen"};
    }
}