using System;
using System.Collections.Generic;
using System.Xml.Linq;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbCommon
{
    public class Common : StbSerializable, IGuid, IStbTag
    {
        public string[] StbTag { get; } = {"StbCommon", ""};
        public string Guid { get; set; }
        public string ProjectName { get; set; }
        public string AppName { get; set; }
        public StrengthConcrete StrengthConcrete { get; set; }

        public List<ReinforcementStrength> ReinforcementStrengthList { get; set; } = new List<ReinforcementStrength>();
        public List<ApplyConditions> ApplyConditionsList { get; set; } = new List<ApplyConditions>();

        protected override void SetProperties(XDocument xDocument, Version version, string xmlns)
        {
            IEnumerable<XElement> xElems = Util.GetXElements(xDocument, xmlns, StbTag, version);

            foreach (XElement elem in xElems)
            {
                ProjectName = (string)elem.Attribute("project_name");
                AppName = (string) elem.Attribute("app_name");
                StrengthConcrete = Util.GetStrengthConcrete((string)elem.Attribute("concrete_strength"));

                XElement items = elem.Element("StbReinforcement_Strength_List");
                IEnumerable<XNode> nodes = items.Nodes();
                foreach (XNode node in nodes)
                {
                    var barStrength = new ReinforcementStrength();
                    barStrength.Deserialize(node, version, xmlns);
                    ReinforcementStrengthList.Add(barStrength);
                }
            }
        }
    }

    public class ReinforcementStrength
    {
        public string Name { get; set; }
        public StrengthBar StrengthBar { get; set; }

        public void Deserialize(XNode node, Version version, string xmlns)
        {
            var element = (XElement) node;
            Name = (string) element.Attribute("D");
            StrengthBar = Util.GetStrengthBar((string) element.Attribute("SD"));
        }
    }

    public class ApplyConditions : StbElementSerializable
    {
    }
}