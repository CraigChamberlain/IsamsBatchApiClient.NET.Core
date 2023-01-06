using System.Xml.Serialization;

public abstract class Entity
{
    /// <summary>
    /// The auto-generated Id of record.
    /// </summary>
    [XmlAttribute]
    public int Id { get; set; }
}