using System.Xml.Serialization;

namespace STBDotNet.v140.StbExtension
{
    public class Extensions
    {
        [XmlElement("StbExtension")] public Extension[] Extension { get; set; }
    }

    public class Extension
    {
        [XmlAttribute("identifier")] public string Identifier { get; set; }
        [XmlAttribute("description")] public string Description { get; set; }
        // child element
        [XmlElement("StbExtObject")] public ExtObject[] ExtObjects { get; set; }
        [XmlElement("StbExtElemtne")] public ExtElement[] ExtElements { get; set; }
    }

    public class ExtObject
    {
        [XmlAttribute("objectName")] public string ObjectName { get; set; }
        [XmlAttribute("objectID")] public int ObjectId { get; set; }
        // child element
        [XmlElement("StbExtProperty")] public ExtProperty[] ExtProperties { get; set; }
    }

    public class ExtProperty
    {
        [XmlAttribute("key")] public string Key { get; set; }
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("value")] public string Value { get; set; }
    }

    public class ExtElement
    {
        [XmlAttribute("objectName")] public string ObjectName { get; set; }
        [XmlAttribute("elementName")] public string ElementName { get; set; }
        // child element
        [XmlElement("StbExtPropertyDef")] public ExtPropertyDefinition[] ExtPropertyDefinitions { get; set; }
    }

    public class ExtPropertyDefinition
    {
        [XmlAttribute("key")] public string Key { get; set; }
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("default")] public string Default { get; set; }
    }
}