using System;
using STBDotNet.Serialization;

namespace STBDotNet.Elements
{
    public interface IGuid
    {
        string Guid { get; set; }
    }

    public interface IStbTag
    {
        string[] StbTag { get; }
    }

    public class StbElementBase : StbSerializable
    {
        private static string[] _stbTag;

        public static string GetStbTag(Version version)
        {
            switch (version)
            {
                case Version.Stb1:
                    return _stbTag[0];
                case Version.Stb2:
                    return _stbTag[1];
                default:
                    throw new ArgumentOutOfRangeException(nameof(version), version, null);
            }
        }
    }
}