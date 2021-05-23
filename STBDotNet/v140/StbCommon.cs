using System.Collections.Generic;
using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public class StbCommon
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
        public List<StbReinforcementStrength> ReinforcementStrengthList { get; set; }
    }

    public class StbReinforcementStrength
    {
        [XmlAttribute("D")]
        public string Name { get; set; }
        [XmlAttribute("SD")]
        public string StrengthBar { get; set; }
    }
}