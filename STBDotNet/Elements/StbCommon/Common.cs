using System.Collections.Generic;

namespace STBDotNet.Elements.StbCommon
{
    public class Common:IGuid
    {
        public string Guid { get; set; }
        public string ProjectName { get; set; }
        public string AppName { get; set; }
        public string StrengthConcrete { get; set; }

        public List<ReinforcementStrength> ReinforcementStrengthList { get; set; }
        public List<ApplyConditions> ApplyConditionsList { get; set; }
    }

    public class ReinforcementStrength
    {
    }

    public class ApplyConditions
    {
    }
}