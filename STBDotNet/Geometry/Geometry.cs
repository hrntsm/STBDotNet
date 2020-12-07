using System;

namespace STBDotNet.Geometry
{
    public struct Point3:IEquatable<Point3>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public Point3(Point3 pt)
        {
            X = pt.X;
            Y = pt.Y;
            Z = pt.Z;
        }
 
        public bool Equals(Point3 other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        public override bool Equals(object obj)
        {
            return obj is Point3 other && Equals(other);
        }

#if NET5_0
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
#endif
    }

    public struct Line3:IEquatable<Line3>
    {
        public Point3 Start { get; set; }
        public Point3 End { get; set; }
        public double Length { get; set; }

        public Line3(Point3 start, Point3 end)
        {
            Start = start;
            End = end;
            Length = Math.Sqrt(
                  Math.Pow(End.X - Start.X, 2)
                + Math.Pow(End.Y - Start.Y, 2)
                + Math.Pow(End.Z - Start.Z, 2));
        }
        
        public Line3(Line3 ln)
        {
            Start = ln.Start;
            End = ln.End;
            Length = ln.Length;
        }
        
        public bool Equals(Line3 other)
        {
            return Start.Equals(other.Start) && End.Equals(other.End);
        }

        public override bool Equals(object obj)
        {
            return obj is Line3 other && Equals(other);
        }

#if NET5_0
        public override int GetHashCode()
        {
            return HashCode.Combine(Start, End);
        }
#endif
    }

    public struct Mesh:IEquatable<Mesh>
    {
        public Point3 A { get; set; }
        public Point3 B { get; set; }
        public Point3 C { get; set; }
        
        public Mesh(Point3 a, Point3 b, Point3 c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Mesh(Mesh mesh)
        {
            A = mesh.A;
            B = mesh.B;
            C = mesh.C;
        }

        public bool Equals(Mesh other)
        {
            return A.Equals(other.A) && B.Equals(other.B) && C.Equals(other.C);
        }

        public override bool Equals(object obj)
        {
            return obj is Mesh other && Equals(other);
        }

#if NET5_0
        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }
#endif
    }
}
