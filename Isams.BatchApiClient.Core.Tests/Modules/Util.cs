using System;
using System.Reflection;
using System.Xml.Serialization;
using System.Xml;
using Isams.BatchApiClient.Core.Services;

namespace Isams.BatchApiClient.Core.Tests.Modules
{
    internal class Util
    {
        public static Deserialiser CreateDeserialiser()  
        {
            return Deserialiser.CreateDeserialiser(
                    new XmlNodeEventHandler(Serializer_UnknownNode), 
                    new XmlAttributeEventHandler(Serializer_UnknownAttribute)
            );
        }

        private static void Serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
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
        }

        private static void Serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }
    }
}
