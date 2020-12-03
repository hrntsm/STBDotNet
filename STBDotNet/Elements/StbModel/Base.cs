using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public interface IModel
    {
        int Id { get; set; }
        string Name { get; set; }
    }
    
    public abstract class ModelBase : StbSerializable, IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}