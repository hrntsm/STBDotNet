using System.Collections.Generic;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbCommon
{
    public class Common : StbSerializable, IGuid
    {
        public string Guid { get; set; }
        public string ProjectName { get; set; }
        public string AppName { get; set; }
        public StrengthConcrete StrengthConcrete { get; set; }

        public List<ReinforcementStrength> ReinforcementStrengthList { get; set; } = new List<ReinforcementStrength>();
        public List<ApplyConditions> ApplyConditionsList { get; set; } = new List<ApplyConditions>();
    }

    public class ReinforcementStrength : StbSerializable
    {
    }

    public class ApplyConditions : StbSerializable
    {
    }
}