namespace STBDotNet.Elements
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public struct Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
    }

    public struct Mesh
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
    }
}