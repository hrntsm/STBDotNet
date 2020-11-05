using System.Collections.Generic;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public class Steel
    {
        public List<RollH> RollH { get; set; } = new List<RollH>();
        public List<BuildH> BuildH { get; set; } = new List<BuildH>();
        public List<RollBox> RollBox { get; set; } = new List<RollBox>();
        public List<BuildBox> BuildBox { get; set; } = new List<BuildBox>();
        public List<Pipe> Pipe { get; set; } = new List<Pipe>();
        public List<RollT> RollT { get; set; } = new List<RollT>();
        public List<RollC> RollC { get; set; } = new List<RollC>();
        public List<RollL> RollL { get; set; } = new List<RollL>();
        public List<LipC> LipC { get; set; } = new List<LipC>();
        public List<FlatBar> FlatBar { get; set; } = new List<FlatBar>();
        public List<RoundBar> RoundBar { get; set; } = new List<RoundBar>();
    }

    public class RollH:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecRoll-H", "StbSecRoll-H"};
    }

    public class BuildH:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecBuild-H", "StbSecBuild-H"};
    }

    public class RollBox:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecRoll-BOX", "StbSecRoll-BOX"};
    }

    public class BuildBox:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecBuild-BOX", "StbSecBuild-BOX"};
    }

    public class Pipe:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecPipe", "StbSecPipe"};
    }

    public class RollT:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecRoll-T", "StbSecRoll-T"};
    }

    public class RollC:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecRoll-C", "StbSecRoll-C"};
    }

    public class RollL:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecRoll-L", "StbSecRoll-L"};
    }

    public class LipC:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecRoll-LipC", "StbSecRoll-LipC"};
    }

    public class FlatBar:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecRoll-FB", "StbSecFlatBar"};
    }

    public class RoundBar:SteelSectionBase, IStbTag
    {
        public string[] StbTag { get; } = {"StbSecRoll-Bar", "StbSecRoundBar"};
    }
}