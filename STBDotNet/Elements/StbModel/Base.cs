using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public interface IModel
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}