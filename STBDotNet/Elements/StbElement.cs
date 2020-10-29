using STBDotNet.Elements.StbModel;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbFromIfc;
using STBDotNet.Elements.StbExtension;

namespace STBDotNet.Elements
{
    public class StbElement
    {
        public Version Version { get; set; }
        public Common Common { get; set; }
        public Model Model { get; set; }
        public FromIfc FromIfc { get; set; }
        public Extension Extension { get; set; }
    }
    
    public enum Version
    {
        Stb1,
        Stb2
    }
}