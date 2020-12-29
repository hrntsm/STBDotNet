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

    public interface IStbSerializable
    {
        void OnAfterDeserialize();
        void OnBeforeSerialize();
    }
}