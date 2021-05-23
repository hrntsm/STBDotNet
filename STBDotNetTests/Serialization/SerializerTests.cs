using NUnit.Framework;
using System.Collections.Generic;
using STBDotNet.v140;
using STBDotNet.v140.StbCommon;
using STBDotNet.v140.StbModel;

namespace STBDotNet.Serialization.Tests
{
    [TestFixture]
    public class SerializerTests
    {
        private readonly List<string> _pathList = new List<string>
        {
            "Sample1", "Sample2", "Sample3", "Sample4", "Sample5", "Sample6"
        };

        [Test]
        public void SerializeTest()
        {
            foreach (string path in _pathList)
            {
                var stbPath = $@"../../../../TestStbFiles/ver1/{path}.stb";
                var outPath = $@"../../../Result/{path}.stb";

                // Deserialize Test
                var serializer = new Serializer();
                StbElements model = serializer.Deserialize(stbPath);
                // Serialize Test
                bool result = serializer.Serialize(model, outPath);

                Assert.IsTrue(result);
                if (path == _pathList[0])
                {
                    CommonTest(model);
                    ModelTest(model);
                }
            }
        }

        private void CommonTest(StbElements elements)
        {
            StbCommon common = elements.Common;
            // stbcommon
            Assert.IsTrue(common.Guid == "64F82436-F0EE-43CD-9ABF-4F40ACF9728E");
            Assert.IsTrue(common.ProjectName == "GS");
            Assert.IsTrue(common.AppName == "Archdata Asin");
            Assert.IsTrue(common.StrengthConcrete == "FC21");
            // StbReinforcement_Strength_List
            Assert.IsTrue(common.ReinforcementStrengthList[0].Name == "D6");
            Assert.IsTrue(common.ReinforcementStrengthList[0].StrengthBar == "SD295A");
            Assert.IsTrue(common.ReinforcementStrengthList[31].Name == "S6");
            Assert.IsTrue(common.ReinforcementStrengthList[31].StrengthBar == "KSS785");
        }

        private void ModelTest(StbElements elements)
        {
            StbModel model = elements.Model;
            NodeTest(model.Nodes);
            StoryTest(model.Stories);
            AxisTest(model.Axes);
        }

        private void NodeTest(List<StbNode> nodes)
        {
            Assert.IsTrue(nodes[4].Id == 5);
            Assert.IsTrue(nodes[4].Kind == "ON_GRID");
            Assert.IsTrue(nodes[4].X == 8179d);
            Assert.IsTrue(nodes[4].Y == 0d);
            Assert.IsTrue(nodes[4].Z == 4970d);
            Assert.IsTrue(nodes[147].Id == 148);
            Assert.IsTrue(nodes[147].Kind == "OTHER");
            Assert.IsTrue(nodes[147].X == 35100.6015625d);
            Assert.IsTrue(nodes[147].Y == 6560d);
            Assert.IsTrue(nodes[147].Z == 4970d);
        }

        private void StoryTest(List<Story> stories)
        {
            Assert.IsTrue(stories[0].Id == 1);
            Assert.IsTrue(stories[0].Name == "1F");
            Assert.IsTrue(stories[0].Height == 0d);
            Assert.IsTrue(stories[0].Kind == "GENERAL");
            Assert.IsTrue(stories[0].ConcreteStrength == "FC21");
            Assert.IsTrue(stories[0].NodeIdList[0].Id == 2);
            Assert.IsTrue(stories[0].NodeIdList[43].Id == 146);
        }

        private void AxisTest(List<Axis> axes)
        {
            Assert.IsTrue(typeof(XAxis) == axes[0].GetType());
            Assert.IsTrue(axes[0].Id == 3);
            Assert.IsTrue(axes[0].Name == "31");
            Assert.IsTrue(axes[0].Distance == 8179d);
            Assert.IsTrue(axes[0].NodeIdList[0].Id == 6);
            Assert.IsTrue(typeof(YAxis) == axes[1].GetType());
            Assert.IsTrue(axes[1].Id == 4);
            Assert.IsTrue(axes[1].Name == "A");
            Assert.IsTrue(axes[1].Distance == 0d);
            Assert.IsTrue(axes[1].NodeIdList[0].Id == 6);
        }
    }
}
