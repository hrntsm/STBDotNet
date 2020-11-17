using System;
using System.Xml.Linq;
using STBDotNet.Elements;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbFromIfc;
using STBDotNet.Elements.StbModel;

namespace STBDotNet.Serialization
{
    public class Deserializer
    {
        /// <summary>
        /// ST-Bridge file path
        /// </summary>
        public string Path { get; }

        private static string _xmlns;
        private readonly StbElements _stbElements;
        private readonly XDocument _xDocument;
        
        public Deserializer(string path)
        {
            Path = path;
            _stbElements = new StbElements();
            try
            {
                _xDocument = XDocument.Load(Path);
                XElement root = _xDocument.Root;
                if (root == null)
                {
                    throw new ArgumentException("Stb data is null");
                }
                _xmlns = Util.GetXmlNameSpace(root);
                _stbElements.Version = Util.GetStbVersion(root);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public StbElements Elements()
        {
            _stbElements.Common.Deserialize(_xDocument, _stbElements.Version, _xmlns);
            _stbElements.Model.Deserialize(_xDocument, _stbElements.Version, _xmlns);
            _stbElements.FromIfc.Deserialize(_xDocument, _stbElements.Version, _xmlns);
            _stbElements.Extensions.Deserialize(_xDocument, _stbElements.Version, _xmlns);

            return _stbElements;
        }

        public Common Common()
        {
            _stbElements.Common.Deserialize(_xDocument, _stbElements.Version, _xmlns);

            return _stbElements.Common;
        }

        public Model Model()
        {
            _stbElements.Model.Deserialize(_xDocument, _stbElements.Version, _xmlns);

            return _stbElements.Model;
        }

        public FromIfc FromIfc()
        {
            _stbElements.FromIfc.Deserialize(_xDocument, _stbElements.Version, _xmlns);

            return _stbElements.FromIfc;
        }

        public Elements.StbExtension.Extensions Extensions()
        {
            _stbElements.Extensions.Deserialize(_xDocument, _stbElements.Version, _xmlns);

            return _stbElements.Extensions;
        }
    }
}