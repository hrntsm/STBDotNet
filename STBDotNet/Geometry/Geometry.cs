using System;

namespace STBDotNet.Geometry
{
    public struct Point:IEquatable<Point>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Point(Point pt)
        {
            X = pt.X;
            Y = pt.Y;
            Z = pt.Z;
        }
 
        public bool Equals(Point other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        public override bool Equals(object obj)
        {
            return obj is Point other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
    }

    public struct Line:IEquatable<Line>
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        
        public Line(Line ln)
        {
            Start = ln.Start;
            End = ln.End;
        }
        
        public bool Equals(Line other)
        {
            return Start.Equals(other.Start) && End.Equals(other.End);
        }

        public override bool Equals(object obj)
        {
            return obj is Line other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Start, End);
        }
    }

    public struct Mesh:IEquatable<Mesh>
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        
        public Mesh(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool Equals(Mesh other)
        {
            return A.Equals(other.A) && B.Equals(other.B) && C.Equals(other.C);
        }

        public override bool Equals(object obj)
        {
            return obj is Mesh other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }
    }
}
