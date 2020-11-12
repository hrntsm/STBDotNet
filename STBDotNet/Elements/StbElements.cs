using STBDotNet.Elements.StbModel;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbFromIfc;
using STBDotNet.Elements.StbExtension;

namespace STBDotNet.Elements
{
    public class StbElements
    {
        public Version Version { get; set; }
        public Common Common { get; set; } = new Common();
        public Model Model { get; set; } = new Model();
        public FromIfc FromIfc { get; set; } = new FromIfc();
        public Extension Extension { get; set; } = new Extension();
    }
    
    public enum Version
    {
        Stb1,
        Stb2
    }
}