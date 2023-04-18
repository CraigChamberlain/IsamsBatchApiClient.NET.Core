using System;
#if DEBUG
using System.Reflection;
#endif
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Services
{
    public class Deserialiser
    {
        private readonly XmlSerializer _serialiser;

        private Deserialiser(XmlSerializer serialiser)
        {
            _serialiser = serialiser;
        }

        public static Deserialiser CreateDeserialiser()
        {
            var serializer = new XmlSerializer(typeof(Collections.Isams), new XmlRootAttribute("iSAMS"));
            return new Deserialiser(serializer);
        }

        public static Deserialiser CreateDeserialiser(XmlNodeEventHandler unknownXmlNodeEventHandler, XmlAttributeEventHandler unknownXmlAttributeEventHandler)
        {
            var serializer = new XmlSerializer(typeof(Collections.Isams), new XmlRootAttribute("iSAMS"));
            serializer.UnknownNode += unknownXmlNodeEventHandler;
            serializer.UnknownAttribute += unknownXmlAttributeEventHandler;
            return new Deserialiser(serializer);
        }

        public Collections.Isams DeserialiseStream(Stream stream)
        {
            return (Collections.Isams)_serialiser.Deserialize(stream);
        }
    }
}