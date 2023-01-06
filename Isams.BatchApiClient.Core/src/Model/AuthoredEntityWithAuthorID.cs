using System.Xml.Serialization;

public abstract class AuthoredEntityWithAuthorID : AuthoredEntity
{
    /// <summary>
    /// The auto-generated Id of the last user to update or create this record.
    /// </summary>
    [XmlAttribute]
    public int AuthorId { get; set; }
}
