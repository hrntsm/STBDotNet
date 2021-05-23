namespace STBDotNet.v140
{
    public interface IStbSerializable
    {
        void OnAfterDeserialize();
        void OnBeforeSerialize();
    }
}