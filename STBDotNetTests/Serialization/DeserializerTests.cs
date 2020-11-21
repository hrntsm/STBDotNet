﻿using NUnit.Framework;
using System.Collections.Generic;
using STBDotNet.Elements;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbExtension;
using STBDotNet.Elements.StbFromIfc;
using STBDotNet.Elements.StbModel;
using STBDotNet.Geometry;

namespace STBDotNet.Serialization.Tests
{
    [TestFixture]
    public class DeserializerTests
    {
        private readonly List<string> _pathList = new List<string>
        {
            @"../../../../TestStbFiles/ver1/Sample1.stb",
            // @"../../../../TestStbFiles/ver1/Sample2.stb",
            // @"../../../../TestStbFiles/ver1/Sample3.stb",
            // @"../../../../TestStbFiles/ver1/Sample4.stb",
            // @"../../../../TestStbFiles/ver1/Sample5.stb",
            // @"../../../../TestStbFiles/ver1/Sample6.stb"
        };

        [Test]
        public void ElementsTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                item.Elements();
            }
        }

        [Test]
        public void CommonTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                Common common = item.Common();
                // stbcommon
                Assert.IsTrue(common.Guid == "64F82436-F0EE-43CD-9ABF-4F40ACF9728E");
                Assert.IsTrue(common.ProjectName == "GS");
                Assert.IsTrue(common.AppName == "Archdata Asin");
                Assert.IsTrue(common.StrengthConcrete == StrengthConcrete.Fc21);
                // StbReinforcement_Strength_List
                Assert.IsTrue(common.ReinforcementStrengthList[0].Name == "D6");
                Assert.IsTrue(common.ReinforcementStrengthList[0].StrengthBar == StrengthBar.S295);
                Assert.IsTrue(common.ReinforcementStrengthList[31].Name == "S6");
                Assert.IsTrue(common.ReinforcementStrengthList[31].StrengthBar == StrengthBar.S785);
            }
        }

        [Test]
        public void ModelTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                Model model = item.Model();
                NodeTest(model.Nodes);
                StoryTest(model.Stories);
                AxisTest(model.Axes);
            }
        }

        private static void NodeTest(IReadOnlyList<Node> nodes)
        {
            Assert.IsTrue(nodes[4].Id == 5);
            Assert.IsTrue(nodes[4].NodeKind == NodeKind.OnGrid);
            Assert.IsTrue(nodes[4].Position.Equals(new Point(8179d, 0d, 4970d)));
            Assert.IsTrue(nodes[147].Id == 148);
            Assert.IsTrue(nodes[147].NodeKind == NodeKind.Other);
            Assert.IsTrue(nodes[147].Position.Equals(new Point(35100.6015625d, 6560d, 4970d)));
        }

        private static void StoryTest(List<Story> stories)
        {
            Assert.IsTrue(stories[0].Id == 1);
            Assert.IsTrue(stories[0].Name == "1F");
            Assert.IsTrue(stories[0].Height == 0d);
            Assert.IsTrue(stories[0].StoryKind == StoryKind.General);
            Assert.IsTrue(stories[0].StrengthConcrete == StrengthConcrete.Fc21);
            Assert.IsTrue(stories[0].NodeIdList[0] == 2);
            Assert.IsTrue(stories[0].NodeIdList[43] == 146);
        }

        private static void AxisTest(Axes axes)
        {
            Assert.IsTrue(axes.ParallelAxes[0].GroupName == "X_Axis");
            Assert.IsTrue(axes.ParallelAxes[0].ParallelAxis[0].Id == 3);
            Assert.IsTrue(axes.ParallelAxes[0].ParallelAxis[0].Name == "31");
            Assert.IsTrue(axes.ParallelAxes[0].ParallelAxis[0].Distance == 8179d);
            Assert.IsTrue(axes.ParallelAxes[0].ParallelAxis[0].NodeIdList[0] == 6);
            Assert.IsTrue(axes.ParallelAxes[1].GroupName == "Y_Axis");
            Assert.IsTrue(axes.ParallelAxes[1].ParallelAxis[0].Id == 4);
            Assert.IsTrue(axes.ParallelAxes[1].ParallelAxis[0].Name == "A");
            Assert.IsTrue(axes.ParallelAxes[1].ParallelAxis[0].Distance == 0d);
            Assert.IsTrue(axes.ParallelAxes[1].ParallelAxis[0].NodeIdList[0] == 6);
        }

        [Test]
        public void FromIfcTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                item.FromIfc();
            }
        }

        [Test]
        public void ExtensionsTest()
        {
            foreach (string path in _pathList)
            {
                var item = new Deserializer(path);
                item.Extensions();
            }
        }
    }
}