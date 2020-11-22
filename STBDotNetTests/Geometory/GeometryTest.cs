using NUnit.Framework;

namespace STBDotNet.Geometry.Tests
{
    [TestFixture]
    public class GeometryTest
    {
        [Test]
        public void PointTest()
        {
            var pt = new Point(0, 0, 0);
            Assert.IsTrue(pt.Equals(new Point(pt)));
            Assert.IsTrue(pt.X == 0);
        }

        [Test]
        public void LineTest()
        {
            var ln = new Line( new Point(0,0,0), new Point(1,0,0));
            Assert.IsTrue(ln.Equals( new Line(ln)));
            Assert.IsTrue(ln.Length == 1);
        }

        [Test]
        public void MeshTest()
        {
            var mesh = new Mesh(new Point(0, 0, 0), new Point(1, 0, 0), new Point(1, 1, 0));
            Assert.IsTrue(mesh.Equals(new Mesh(mesh)));
        }
    }
}