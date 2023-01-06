using System.IO;
using System.Xml.Serialization;
using Isams.BatchApiClient.Core.Requests;

namespace Isams.BatchApiClient.Core.Services
{
    public class RequestSeserialiser
    {
        private readonly XmlSerializer _serialiser;

        private RequestSeserialiser(XmlSerializer serialiser)
        {
            _serialiser = serialiser;
        }

        public static RequestSeserialiser CreateSerialiser()
        {
            var serializer = new XmlSerializer(typeof(Filters));
            return new RequestSeserialiser(serializer);
        }

        public void SerialiseToStream(Stream stream, Filters filters)
        {
            _serialiser.Serialize(stream, filters);
            stream.Position = 0;
#if DEBUG
            StreamReader sr = new (stream);
            var s = sr.ReadToEnd();
            stream.Position = 0;
#endif
        }
    }
}