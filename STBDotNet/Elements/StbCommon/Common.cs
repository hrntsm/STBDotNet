using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbCommon
{
    public class Common
    {
        [XmlAttribute("globalID")]
        public string Guid { get; set; }
        [XmlAttribute("project_name")]
        public string ProjectName { get; set; }
        [XmlAttribute("app_name")]
        public string AppName { get; set; }
        [XmlAttribute("concrete_strength")]
        public string StrengthConcrete { get; set; }
        [XmlArray("StbReinforcement_Strength_List")]
        [XmlArrayItem("StbReinforcement_Strength")]
        public List<ReinforcementStrength> ReinforcementStrengthList { get; set; } = new List<ReinforcementStrength>();
        public List<ApplyConditions> ApplyConditionsList { get; set; } = new List<ApplyConditions>();
    }

    public class ReinforcementStrength
    {
        [XmlAttribute("D")]
        public string Name { get; set; }
        [XmlAttribute("SD")]
        public string StrengthBar { get; set; }
    }

    public class ApplyConditions : StbElementSerializable
    {
    }
}