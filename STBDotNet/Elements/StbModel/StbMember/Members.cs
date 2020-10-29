using System.Collections.Generic;
using STBDotNet.Elements.Base;

namespace STBDotNet.Elements.StbModel
{
    public class Members
    {
        public List<Column> Columns { get; set; }
        public List<Post> Posts { get; set; }
        public List<Girder> Girders { get; set; }
        public List<Beam> Beams { get; set; }
        public List<Brace> Braces { get; set; }
        public List<Slab> Slabs { get; set; }
        public List<Wall> Walls { get; set; }
        public List<Footing> Footings { get; set; }
        public List<StripFooting> StripFootings { get; set; }
        public List<Pile> Piles { get; set; }
        public List<FoundationColumn> FoundationColumns { get; set; }
        public List<Parapet> Parapets { get; set; }
        public List<Open> Opens { get; set; }
    }

    public class Column:IModel
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Post
    {
    }

    public class Girder
    {
    }

    public class Beam
    {
    }

    public class Brace
    {
    }

    public class Slab
    {
    }

    public class Wall
    {
    }

    public class Footing
    {
    }

    public class StripFooting
    {
    }

    public class Pile
    {
    }

    public class FoundationColumn
    {
    }

    public class Parapet
    {
    }

    public class Open
    {
    }
}