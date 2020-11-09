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
}