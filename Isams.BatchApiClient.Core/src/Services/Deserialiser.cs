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
            serializer.UnknownNode += new
            XmlNodeEventHandler(Serializer_UnknownNode);
            serializer.UnknownAttribute += new
            XmlAttributeEventHandler(Serializer_UnknownAttribute);
            return new Deserialiser(serializer);
        }

        public Collections.Isams DeserialiseStream(Stream stream)
        {
            return (Collections.Isams)_serialiser.Deserialize(stream);
        }

        private static void Serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            // Don't want to perform Reflection in production.  Helps to seperate noise from trees in development.
#if DEBUG
            var x = (XmlNode)typeof(XmlNodeEventArgs).GetField("_xmlNode", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).GetValue(e);

            // Depricated Nodes
            if (x.Attributes != null)
            {
                foreach (XmlAttribute node in x.Attributes)
                {
                    if (node.Name == "Legacy" &&
                    node.Value == "True")
                    {
                        return;
                    }
                }
            }

            // Known Nodes to be ignored as XML is Odd
            if (e.Name == "ModuleId" && e.ObjectBeingDeserialized.ToString() == "Isams.BatchApiClient.Model.ControlPanel.Permission")
            {
                return;
            }

            if (e.Name == "DivisionId" && e.ObjectBeingDeserialized.ToString() == "DailyBulletin.Bulletin+LinkedDivision")
            {
                return;
            }

            if (e.Name == "CategoryId" && e.ObjectBeingDeserialized.ToString() == "Isams.BatchApiClient.Model.RewardsAndConduct.Record")
            {
                return;
            }

            throw new Exception("Unknown Node:" + e.Name + "\t" + e.Text + "\t in node:" + e.ObjectBeingDeserialized);
#endif
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text + "\t in node:" + e.ObjectBeingDeserialized);
        }

        private static void Serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }
    }
}