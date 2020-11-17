using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbExtension
{
    public class Extensions : StbSerializable, IGuid, IStbTag
    {
        public string Guid { get; set; }
        public string[] StbTag { get; } = {"StbExtensions", ""};
    }
}