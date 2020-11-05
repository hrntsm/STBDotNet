namespace STBDotNet.Elements
{
    public interface IGuid
    {
        public string Guid { get; set; }
    }

    public interface IStbTag
    {
        public string[] StbTag { get; }
    }
}