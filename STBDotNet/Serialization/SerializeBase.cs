using System.Xml.Linq;
using STBDotNet.Elements;

namespace STBDotNet.Serialization
{
    public interface IStbSerializable
    {
        // XElement Serialize();
        void Deserialize(XDocument xDocument);
        void Deserialize(XDocument xDocument, Version version, string xmlns);
    }

    public interface IStbElementSerializable
    {
        // XElement Serialize();
        void Deserialize(XElement xElement);
        void Deserialize(XElement xElement, Version version, string xmlns);
    }

    public abstract class StbSerializable : IStbSerializable
    {

        public void Deserialize(XDocument xDocument)
        {
            XElement root = xDocument.Root;
            if (root == null)
            {
                return;
            }

            string xmlns = Util.GetXmlNameSpace(root);
            Version version = Util.GetStbVersion(root);
            SetProperties(xDocument, version, xmlns);
        }

        public void Deserialize(XDocument xDocument, Version version, string xmlns)
        {
            SetProperties(xDocument, version, xmlns);
        }

        protected virtual void SetProperties(XDocument xDocument, Version version, string xmlns)
        {
        }
    }

    public abstract class StbElementSerializable : IStbElementSerializable
    {
        public void Deserialize(XElement xElement)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(XElement xElement, Version version, string xmlns)
        {
            SetProperties(xElement, version, xmlns);
        }

        protected virtual void SetProperties(XElement xElement, Version version, string xmlns)
        {
        }
    }

}