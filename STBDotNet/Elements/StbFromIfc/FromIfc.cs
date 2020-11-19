using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbFromIfc
{
    public class FromIfc : StbSerializable, IGuid, IStbTag
    {
        public string Guid { get; set; }
        public string[] StbTag { get; } = {"StbFromIfc", ""};
    }
}