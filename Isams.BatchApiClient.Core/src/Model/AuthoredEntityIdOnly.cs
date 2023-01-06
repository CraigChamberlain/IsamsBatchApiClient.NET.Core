using System.Xml.Serialization;

public abstract class AuthoredEntityIdOnly : DatedEntity
{
    /// <summary>
    /// The auto-generated Id of the last user to update or create this record.
    /// </summary>
    [XmlAttribute]
    public int AuthorId { get; set; }
}
