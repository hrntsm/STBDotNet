using NUnit.Framework;

namespace STBDotNet.Geometry.Tests
{
    [TestFixture]
    public class GeometryTest
    {
        [Test]
        public void Point3Test()
        {
            var pt = new Point3(0, 0, 0);
            Assert.IsTrue(pt.Equals(new Point3(pt)));
            Assert.IsTrue(pt.X == 0);
        }

        [Test]
        public void Line3Test()
        {
            var ln = new Line3(new Point3(0, 0, 0), new Point3(1, 0, 0));
            Assert.IsTrue(ln.Equals(new Line3(ln)));
            Assert.IsTrue(ln.Length == 1);
        }

        [Test]
        public void MeshTest()
        {
            var mesh = new Mesh(new Point3(0, 0, 0), new Point3(1, 0, 0), new Point3(1, 1, 0));
            Assert.IsTrue(mesh.Equals(new Mesh(mesh)));
        }
    }
}