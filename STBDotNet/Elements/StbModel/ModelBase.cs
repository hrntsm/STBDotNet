namespace STBDotNet.Elements.StbModel
{

    public interface IModel: IGuid
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    public abstract class ModelBase : IModel
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}