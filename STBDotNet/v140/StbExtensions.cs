using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public class StbExtensions
    {
        [XmlElement("StbExtension")] public StbExtension[] Extension { get; set; }
    }

    public class StbExtension
    {
        [XmlAttribute("identifier")] public string Identifier { get; set; }
        [XmlAttribute("description")] public string Description { get; set; }
        // child element
        [XmlElement("StbExtObject")] public StbExtObject[] ExtObjects { get; set; }
        [XmlElement("StbExtElemtne")] public StbExtElement[] ExtElements { get; set; }
    }

    public class StbExtObject
    {
        [XmlAttribute("objectName")] public string ObjectName { get; set; }
        [XmlAttribute("objectID")] public int ObjectId { get; set; }
        // child element
        [XmlElement("StbExtProperty")] public StbExtProperty[] ExtProperties { get; set; }
    }

    public class StbExtProperty
    {
        [XmlAttribute("key")] public string Key { get; set; }
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("value")] public string Value { get; set; }
    }

    public class StbExtElement
    {
        [XmlAttribute("objectName")] public string ObjectName { get; set; }
        [XmlAttribute("elementName")] public string ElementName { get; set; }
        // child element
        [XmlElement("StbExtPropertyDef")] public StbExtPropertyDefinition[] ExtPropertyDefinitions { get; set; }
    }

    public class StbExtPropertyDefinition
    {
        [XmlAttribute("key")] public string Key { get; set; }
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("default")] public string Default { get; set; }
    }
}