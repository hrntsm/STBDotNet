using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public interface IModel: IGuid
    {
        int Id { get; set; }
        string Name { get; set; }
    }
    
    public abstract class ModelBase : StbSerializable, IModel
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}